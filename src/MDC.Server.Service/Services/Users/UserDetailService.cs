using AutoMapper;
using MDC.Server.Service.Helpers;
using MDC.Server.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using MDC.Server.Service.Exceptions;
using MDC.Server.Domain.Configurations;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Service.DTOs.UserDetails;
using MDC.Server.Service.Commons.Extensions;

namespace MDC.Server.Service.Services.Users;

public class UserDetailService
{
    private readonly IMapper _mapper;
    private readonly IUserDetailRepository _userDetailRepository;

    public UserDetailService(IMapper mapper, IUserDetailRepository userDetailRepository)
    {
        this._mapper = mapper;
        this._userDetailRepository = userDetailRepository;
    }

    public async Task<UserDetailForResultDto> CreateAsync(UserDetailForCreationDto dto)
    {
        var userDetail = await _userDetailRepository.SelectAll()
            .Where(ud => ud.UserId == dto.UserId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (userDetail is not null)
            throw new MDCException(409, "UserDetails is already exist");

        #region Image
        var imageFileName = Guid.NewGuid().ToString("N") + Path.GetExtension(dto.Image.FileName);
        var imageRootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "Media", "UserDetails", "Images", imageFileName);
        using (var stream = new FileStream(imageRootPath, FileMode.Create))
        {
            await dto.Image.CopyToAsync(stream);
            await stream.FlushAsync();
            stream.Close();
        }
        string imageResult = Path.Combine("Media", "UserDetails", "Images", imageFileName);
        #endregion

        #region Resume
        var resumeFileName = Guid.NewGuid().ToString("N") + Path.GetExtension(dto.Resume.FileName);
        var resumeRootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "Media", "UserDetails", "Resumes", resumeFileName);
        using (var stream = new FileStream(resumeRootPath, FileMode.Create))
        {
            await dto.Resume.CopyToAsync(stream);
            await stream.FlushAsync();
            stream.Close();
        }
        string resumeResult = Path.Combine("Media", "UserDetails", "Resumes", resumeFileName);

        var mappedUserDetail = _mapper.Map<UserDetail>(dto);
        mappedUserDetail.CreatedAt = DateTime.UtcNow;
        #endregion

        mappedUserDetail.Image = imageResult;
        mappedUserDetail.Resume = resumeResult;

        var result = await _userDetailRepository.InsertAsync(mappedUserDetail);

        return this._mapper.Map<UserDetailForResultDto>(result);
    }

    public async Task<UserDetailForResultDto> ModifyAsync(long id, UserDetailForUpdateDto dto)
    {
        var userDetail = await _userDetailRepository.SelectAll()
                .Where(ud => ud.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();

        if (userDetail is null)
            throw new MDCException(404, "UserDetail is not found");

        #region Image
        var imageFullPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, userDetail.Image);

        if (File.Exists(imageFullPath))
            File.Delete(imageFullPath);

        var imageFileName = Guid.NewGuid().ToString("N") + Path.GetExtension(dto.Image.FileName);
        var imageRootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "Media", "UserDetails", "Images", imageFileName);
        using (var stream = new FileStream(imageRootPath, FileMode.Create))
        {
            await dto.Image.CopyToAsync(stream);
            await stream.FlushAsync();
            stream.Close();
        }
        string imageResult = Path.Combine("Media", "UserDetails", "Images", imageFileName);
        #endregion

        #region Resume
        var resumeFullPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, userDetail.Resume);

        if (File.Exists(resumeFullPath))
            File.Delete(resumeFullPath);

        var resumeFileName = Guid.NewGuid().ToString("N") + Path.GetExtension(dto.Resume.FileName);
        var resumeRootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "Media", "UserDetails", "Resumes", resumeFileName);
        using (var stream = new FileStream(resumeRootPath, FileMode.Create))
        {
            await dto.Resume.CopyToAsync(stream);
            await stream.FlushAsync();
            stream.Close();
        }
        string resumeResult = Path.Combine("Media", "UserDetails", "Resumes", resumeFileName);
        #endregion

        var mappedUserDetail = this._mapper.Map(dto, userDetail);
        mappedUserDetail.UpdatedAt = DateTime.UtcNow;

        mappedUserDetail.Image = imageResult;
        mappedUserDetail.Resume = resumeResult;

        await this._userDetailRepository.UpdateAsync(mappedUserDetail);

        return this._mapper.Map<UserDetailForResultDto>(mappedUserDetail);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var userDetail = await this._userDetailRepository.SelectAll()
                .Where(ud => ud.Id == id)
                .FirstOrDefaultAsync();

        if (userDetail is null)
            throw new MDCException(404, "UserDetail is not found");

        #region Image
        var imageFullPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, userDetail.Image);

        if (File.Exists(imageFullPath))
            File.Delete(imageFullPath);
        #endregion

        #region Resume
        var resumeFullPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, userDetail.Resume);

        if (File.Exists(resumeFullPath))
            File.Delete(resumeFullPath);
        #endregion

        return await this._userDetailRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<UserDetailForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var userDetail = await _userDetailRepository.SelectAll()
                .Include(ud => ud.User)
                .AsNoTracking()
                .ToPagedList(@params)
                .ToListAsync();

        return _mapper.Map<IEnumerable<UserDetailForResultDto>>(userDetail);
    }

    public async Task<UserDetailForResultDto> RetrieveByIdAsync(long id)
    {
        var userDetail = await this._userDetailRepository.SelectAll()
                .Where(c => c.Id == id)
                .Include(ud => ud.User)
                .AsNoTracking()
                .FirstOrDefaultAsync();

        if (userDetail is null)
            throw new MDCException(404, "UserDetail is not found");

        return this._mapper.Map<UserDetailForResultDto>(userDetail);
    }
}
