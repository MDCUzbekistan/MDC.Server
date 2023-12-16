using MDC.Server.Service.Commons.Extensions;
using MDC.Server.Service.DTOs.UserDetails;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Domain.Configurations;
using MDC.Server.Data.IRepositories;
using MDC.Server.Service.Exceptions;
using MDC.Server.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace MDC.Server.Service.Services.Users;

public class UserDetailService : IUserDetailService
{
    private readonly IMapper _mapper;
    private readonly IRepository<UserDetail, long> _userDetailRepository;
    public UserDetailService(IMapper mapper, IRepository<UserDetail, long> userDetailRepository)
    {
        this._mapper = mapper;
        this._userDetailRepository = userDetailRepository;
    }

    public async Task<UserDetailForResultDto> CreateAsync(UserDetailForCreationDto dto)
    {
        var userDetail = await _userDetailRepository.SelectAll()
            .Where(uD => uD.UserId == dto.UserId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (userDetail is not null)
            throw new MDCException(409, "User is already exist");

        var mappedUserDetail = _mapper.Map<UserDetail>(dto);
        mappedUserDetail.CreatedAt = DateTime.UtcNow;

        var result = await _userDetailRepository.InsertAsync(mappedUserDetail);

        return this._mapper.Map<UserDetailForResultDto>(result);
    }

    public async Task<UserDetailForResultDto> ModifyAsync(long id, UserDetailForUpdateDto dto)
    {
        var userDetail = await _userDetailRepository.SelectAll()
                .Where(uD => uD.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();

        if (userDetail is null)
            throw new MDCException(404, "UserDetail is not found");

        var mappedUserDetail = this._mapper.Map(dto, userDetail);
        mappedUserDetail.UpdatedAt = DateTime.UtcNow;

        await this._userDetailRepository.UpdateAsync(mappedUserDetail);

        return this._mapper.Map<UserDetailForResultDto>(mappedUserDetail);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var userDetail = await this._userDetailRepository.SelectAll()
                .Where(uD => uD.Id == id)
                .FirstOrDefaultAsync();
        if (userDetail is null)
            throw new MDCException(404, "UserDetail is not found");

        return await this._userDetailRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<UserDetailForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var userDetail = await _userDetailRepository.SelectAll()
                .Include(uD => uD.UserId)
                .AsNoTracking()
                .ToPagedList(@params)
                .ToListAsync();

        return _mapper.Map<IEnumerable<UserDetailForResultDto>>(userDetail);
    }

    public async Task<UserDetailForResultDto> RetrieveByIdAsync(long id)
    {
        var userDetail = await this._userDetailRepository.SelectAll()
                .Where(c => c.Id == id)
                .Include(uD => uD.UserId)
                .AsNoTracking()
                .FirstOrDefaultAsync();

        if (userDetail is null)
            throw new MDCException(404, "UserDetail is not found");

        return this._mapper.Map<UserDetailForResultDto>(userDetail);
    }
}
