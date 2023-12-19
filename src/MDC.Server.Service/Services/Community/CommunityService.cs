using AutoMapper;
using MDC.Server.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using MDC.Server.Service.Exceptions;
using MDC.Server.Service.DTOs.Community;
using MDC.Server.Domain.Entities.Communities;
using MDC.Server.Service.Interfaces.Communities;
using MDC.Server.Service.Helpers;
using MDC.Server.Service.DTOs.CommunityImage;

namespace MDC.Server.Service.Services;

public  class CommunityService : ICommunityService
{
  
    private readonly IMapper _mapper;
    private readonly ICommunityRepository _communityRepository;
    private readonly ICommunityImageRepository _communityImageRepository;

    public CommunityService(IMapper mapper, ICommunityRepository communityRepository, ICommunityImageRepository communityImageRepository)
    {
        _mapper = mapper;
        _communityRepository = communityRepository;
        _communityImageRepository = communityImageRepository;
    }

    public async Task<CommunityForResultDto> CreateAsync(CommunityForCreationDto communityDto)
    {
        var community = await _communityRepository.SelectAll()
            .Where(c => c.Title == communityDto.Title)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (community is not null)
            throw new MDCException(409, "Community already exists !");

        if (communityDto.ParentId != 0)
        {
            var subCommunity = await _communityRepository.SelectAll()
                .Where(sb => sb.Id == communityDto.ParentId)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (subCommunity is null)
                throw new MDCException(404, "SubComunity is not found");
        }

        var mappedComunity = _mapper.Map<Community>(communityDto);
        mappedComunity.CreatedAt = DateTime.UtcNow;
        var createCommunity = await _communityRepository.InsertAsync(mappedComunity);

        return _mapper.Map<CommunityForResultDto>(createCommunity);
    }


    public async Task<bool> DeleteAsync(long Id)
    {
        var community = await _communityRepository.SelectAll()
            .Where(c => c.Id == Id)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (community is null)
            throw new MDCException(404, "Community is not found !");

        return await _communityRepository.DeleteAsync(Id);
    }

    public async Task<IEnumerable<CommunityForResultDto>> RetruveAllAsync()
    {
        var communityes = await _communityRepository.SelectAll()
            .ToListAsync();

        return _mapper.Map<IEnumerable<CommunityForResultDto>>(communityes);
    }

    public async Task<CommunityForResultDto> RetruveByIdAsync(long Id)
    {
        var community = await _communityRepository.SelectAll()
            .Where(c => c.Id == Id)
            .FirstOrDefaultAsync();

        if (community is null)
            throw new MDCException(404, "Community is not found");
        return _mapper.Map<CommunityForResultDto>(community);
    }

    public async Task<CommunityForResultDto> UpdateAsync(long Id, CommunityForUpdateDto Update)
    {
        var community = await _communityRepository.SelectAll()
            .Where(c => c.Id == Id)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (community is null)
            throw new MDCException(404, "Community is not found");

        if (Update.ParentId != 0)
        {
            var subCommunity = await _communityRepository.SelectAll()
                .Where(sb => sb.Id == Update.ParentId)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (subCommunity is null)
                throw new MDCException(404, "SubComunity is not found");
        }

        var mappedCommunity = _mapper.Map<Community>(Update);
        mappedCommunity.UpdatedAt = DateTime.UtcNow;
        var updateCommunity = await _communityRepository.UpdateAsync(mappedCommunity);
        return _mapper.Map<CommunityForResultDto>(updateCommunity);
    }
    
    public async Task<CommunityForResultDto> CreateBannerAsync(long communitId, CommunityImageForCreationDto dto)
    {
        var community = await _communityRepository.SelectAll()
            .Where(e => e.Id == communitId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (community is null)
            throw new MDCException(404, "Community is not found");

        if (community.Banner is not null)
            throw new MDCException(409, "Community Banner already exicts");

        var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(dto.formFile.FileName);
        var rootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "Media", "Community", "Banners", fileName);
        using (var stream = new FileStream(rootPath, FileMode.Create))
        {
            await dto.formFile.CopyToAsync(stream);
            await stream.FlushAsync();
            stream.Close();
        }
        string bannerPath = Path.Combine("Media", "Community", "Banners", fileName);

        community.Banner = bannerPath;

        var mappedCommunity = _mapper.Map<Community>(community);
        var communityResult = await _communityRepository.UpdateAsync(mappedCommunity);

        return _mapper.Map<CommunityForResultDto>(communityResult);
    }
   
    public async Task<CommunityForResultDto> CreateLogoAsync(long communitId, CommunityImageForCreationDto dto)
    {
        var community = await _communityRepository.SelectAll()
            .Where(e => e.Id == communitId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (community  is null)
            throw new MDCException(404, "Community is not found");

        if (community.Logo is not null)
            throw new MDCException(409, "Community logo already exicts");

        var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(dto.formFile.FileName);
        var rootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "Media", "Community", "Logos", fileName);
        using (var stream = new FileStream(rootPath, FileMode.Create))
        {
            await dto.formFile.CopyToAsync(stream);
            await stream.FlushAsync();
            stream.Close();
        }
        string logoPath = Path.Combine("Media", "Community","Logos", fileName);

        community.Logo = logoPath;

        var mappedCommunity = _mapper.Map<Community>(community);
        var createCommunityImage = await _communityRepository.UpdateAsync(mappedCommunity);

        return _mapper.Map<CommunityForResultDto>(createCommunityImage);
    }



    
    public async Task<CommunityForResultDto> UpdateLogoAsync(long communitId, CommunityImageForCreationDto dto)
    {
        var community = await _communityRepository.SelectAll()
            .Where(e => e.Id == communitId)
            .FirstOrDefaultAsync();

        if (community is null)
            throw new MDCException(404, "Community is not found");

        // Delete the existing logo file if needed
        if (!string.IsNullOrEmpty(community.Logo))
        {
            var existingLogoPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, community.Logo);
            if (File.Exists(existingLogoPath))
            {
                File.Delete(existingLogoPath);
            }
        }

        var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(dto.formFile.FileName);
        var rootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "Media", "Community", "Logos", fileName);

        using (var stream = new FileStream(rootPath, FileMode.Create))
        {
            await dto.formFile.CopyToAsync(stream);
            await stream.FlushAsync();
            stream.Close();
        }

        string resultImage = Path.Combine("Media", "Community", "Logos", fileName);

        community.Logo = resultImage;
        var mappedCommunity = _mapper.Map<Community>(community);
        var result = await _communityRepository.UpdateAsync(mappedCommunity);

        return _mapper.Map<CommunityForResultDto>(result);
    }


    public async Task<CommunityForResultDto> UpdateBannerAsync(long communitId, CommunityImageForCreationDto dto)
    {
        var community = await _communityRepository.SelectAll()
            .Where(e => e.Id == communitId)
            .FirstOrDefaultAsync();

        if (community is null)
            throw new MDCException(404, "Community is not found");

        // Delete the existing Banner file if needed
        if (!string.IsNullOrEmpty(community.Logo))
        {
            var existingLogoPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, community.Logo);
            if (File.Exists(existingLogoPath))
            {
                File.Delete(existingLogoPath);
            }
        }

        var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(dto.formFile.FileName);
        var rootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "Media", "Community", "Banners", fileName);

        using (var stream = new FileStream(rootPath, FileMode.Create))
        {
            await dto.formFile.CopyToAsync(stream);
            await stream.FlushAsync();
            stream.Close();
        }

        string resultImage = Path.Combine("Media", "Community", "Banners", fileName);

        community.Banner = resultImage;
        var mappedCommunity = _mapper.Map<Community>(community);
        var result = await _communityRepository.UpdateAsync(mappedCommunity);

        return _mapper.Map<CommunityForResultDto>(result);
    }

}
