using AutoMapper;
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

    public CommunityService(IMapper mapper, ICommunityRepository communityRepository)
    {
        _mapper = mapper;
        _communityRepository = communityRepository;
    }

    public async Task<CommunityForResultDto> CreateAsync(CommunityForCreationDto communityDto)
    {
        var community = await _communityRepository.SelectAll()
            .Where(c => c.Logo == communityDto.Logo)
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

    public async Task<CommunityForResultDto> UpdateAsync(CommunityForUpdateDto Update)
    {
        var community = await _communityRepository.SelectAll()
            .Where(c => c.Id == Update.Id)
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
}
