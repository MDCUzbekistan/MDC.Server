using AutoMapper;
using Microsoft.AspNetCore.Http;
using MDC.Server.Service.Helpers;
using MDC.Server.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using MDC.Server.Service.Exceptions;
using MDC.Server.Service.DTOs.Community;
using MDC.Server.Domain.Entities.Communities;
using MDC.Server.Service.Interfaces.Communities;

namespace MDC.Server.Service.Services;

public  class CommunityService : ICommunityService
{
    private readonly IMapper _mapper;
    private readonly ICommunityRepository _communityRepository;
    private readonly ICommunityImageRepository _communityImageRepository;

    public CommunityService(IMapper mapper, ICommunityRepository communityRepository , ICommunityImageRepository communityImageRepository)
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

            if (subCommunity is null )
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

    public async Task<CommunityImageForResultDto> CreateCommunityLogoAsync(long CommunityId, IFormFile formFile)
    {
        var community = await _communityRepository.SelectAll()
           .Where(c => c.Id == CommunityId)
           .AsNoTracking()
           .FirstOrDefaultAsync();
        if (community is null)
        {
            throw new MDCException(404, "Community is not found");
        }

        var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(formFile.FileName);
        var rootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "Media", "Community", "Banners", formFile.FileName);

        using (var stream = new FileStream(rootPath, FileMode.Create))
        {
            await formFile.CopyToAsync(stream);
            await stream.FlushAsync();
            stream.Close();
        }

        var mappedImage = new CommunityImage()
        {
            Id = CommunityId,
            CreatedAt = DateTime.UtcNow,
            Name = formFile.FileName,
            Size = formFile.Length,
            Type = formFile.ContentType,
            Extension = Path.GetExtension(formFile.FileName),
            Path = Path.Combine("Media", "Community", "Logos", formFile.FileName)
        };

        var result = await _communityImageRepository.InsertAsync(mappedImage);

        return _mapper.Map<CommunityImageForResultDto>(result);
        throw new NotImplementedException();
    }

    public async Task<CommunityImageForResultDto> CreateCommunityBannerAsync(long CommunityId, IFormFile formFile)
    {
        var community = await _communityRepository.SelectAll()
            .Where(c => c.Id == CommunityId)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (community is null)
        {
            throw new MDCException(404, "Community is not found");
        }


        var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(formFile.FileName);
        var rootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "Media", "Community", "Banners", formFile.FileName);

        using (var stream = new FileStream(rootPath, FileMode.Create))
        {
            await formFile.CopyToAsync(stream);
            await stream.FlushAsync();
            stream.Close();
        }

        var mappedImage = new CommunityImage()
        {
            Id = CommunityId,
            CreatedAt = DateTime.UtcNow,
            Name = formFile.FileName,
            Size = formFile.Length,
            Type = formFile.ContentType,
            Extension = Path.GetExtension(formFile.FileName),
            Path = Path.Combine("Media", "Community", "Banners", formFile.FileName)
        };
        
        var result = await _communityImageRepository.InsertAsync(mappedImage);

        return _mapper.Map<CommunityImageForResultDto>(result);
    }

   
    public async Task<CommunityImageForResultDto> UpdateCommunityBannerAsync(long CommunityId, IFormFile formFile)
    {
        var community = await _communityRepository.SelectAll()
         .Where(c => c.Id == CommunityId)
         .FirstOrDefaultAsync();

        if (community is null)
            throw new MDCException(404, "Community is not found");

        var existingImage = await _communityImageRepository.SelectAll()
            .Where(ci => ci.Id == CommunityId)
            .FirstOrDefaultAsync();

        if (existingImage is null)
            throw new MDCException(404, "Community banner not found");
        

        var existingImagePath = Path.Combine(WebHostEnviromentHelper.WebRootPath, existingImage.Path);

        if (File.Exists(existingImagePath))
            File.Delete(existingImagePath);
        else
            throw new MDCException(404, "Banner is not found");
       
        var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(formFile.FileName);
        var rootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "Media", "Community", "Banners", fileName);

        
        using (var stream = new FileStream(rootPath, FileMode.Create))
        {
            await formFile.CopyToAsync(stream);
            await stream.FlushAsync();
        }

        existingImage.Name = formFile.FileName;
        existingImage.Size = formFile.Length;
        existingImage.Type = formFile.ContentType;
        existingImage.Extension = Path.GetExtension(formFile.FileName);
        existingImage.Path = Path.Combine("Media", "Community", "Banners", fileName);

        await _communityImageRepository.UpdateAsync(existingImage);

        return _mapper.Map<CommunityImageForResultDto>(existingImage);
    }

    public async Task<CommunityImageForResultDto> UpdateCommunityLogoAsync(long CommunityId, IFormFile formFile)
    {
        var community = await _communityRepository.SelectAll()
         .Where(c => c.Id == CommunityId)
         .FirstOrDefaultAsync();

        if (community is null)
            throw new MDCException(404, "Community is not found");

        var existingImage = await _communityImageRepository.SelectAll()
            .Where(ci => ci.Id == CommunityId)
            .FirstOrDefaultAsync();

        if (existingImage is null)
            throw new MDCException(404, "Community Logo not found");

        var existingImagePath = Path.Combine(WebHostEnviromentHelper.WebRootPath, existingImage.Path);

        if (File.Exists(existingImagePath))
            File.Delete(existingImagePath);
        else
            throw new MDCException(404, "Logo is not found");


        var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(formFile.FileName);
        var rootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "Media", "Community", "Logos", fileName);

        using (var stream = new FileStream(rootPath, FileMode.Create))
        {
            await formFile.CopyToAsync(stream);
            await stream.FlushAsync();
        }

        existingImage.Name = formFile.FileName;
        existingImage.Size = formFile.Length;
        existingImage.Type = formFile.ContentType;
        existingImage.Extension = Path.GetExtension(formFile.FileName);
        existingImage.Path = Path.Combine("Media", "Community", "Logos", fileName);

        await _communityImageRepository.UpdateAsync(existingImage);

        return _mapper.Map<CommunityImageForResultDto>(existingImage);
    }

}
