using AutoMapper;
using MDC.Server.Data.IRepositories;
using MDC.Server.Domain.Configurations;
using MDC.Server.Domain.Entities.Communities;
using MDC.Server.Service.Commons.Extensions;
using MDC.Server.Service.DTOs.CommunityRoles;
using MDC.Server.Service.Exceptions;
using MDC.Server.Service.Interfaces.CommunityRoles;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace MDC.Server.Service.Services.CommunityRoles;

public class CommunityRoleService : ICommunityRoleService
{
    private readonly IMapper _mapper;
    private readonly ICommunityRoleRepository _repository;
    public CommunityRoleService(IMapper mapper, ICommunityRoleRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<CommunityRoleForResultDto> CreateAsync(CommunityRoleForCreationDto dto)
    {
        var communityRole = await _repository.SelectAll()
            .Where(cr => cr.Name.ToLower() == dto.Name.ToLower())
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (communityRole is not null)
            throw new MDCException(409, "CommunityRole is already exist.");

        var mappedCommunityRole = _mapper.Map<CommunityRole>(dto);
        mappedCommunityRole.CreatedAt = DateTime.UtcNow;

        var createdCommunityRole = await _repository.InsertAsync(mappedCommunityRole);
        return _mapper.Map<CommunityRoleForResultDto>(mappedCommunityRole); 
    }

    public async Task<CommunityRoleForResultDto> ModifyAsync(short id, CommunityRoleForUpdateDto dto)
    {
        var communityRole = await _repository.SelectAll()
            .Where(cr => cr.Name.ToLower() == dto.Name.ToLower())
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (communityRole is null)
            throw new MDCException(404, "CommunityRole not found.");
        
        communityRole.UpdatedAt = DateTime.UtcNow;
        var CR = _mapper.Map(dto,communityRole);

        await _repository.UpdateAsync(CR);

        return _mapper.Map<CommunityRoleForResultDto>(CR);
    }

    public async Task<bool> RemoveAsync(short id)
    {
        var communityRole = await _repository.SelectAll()
            .Where(cr => cr.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (communityRole is null)
            throw new MDCException(404, "CommunityRole not found.");

        await _repository.DeleteAsync(id);
        return true;
    }

    public async Task<IEnumerable<CommunityRoleForResultDto>> RetrieveAllAsync()
    {
        var communityRole = await _repository.SelectAll().ToListAsync();

        return _mapper.Map<IEnumerable<CommunityRoleForResultDto>>(communityRole);
    }

    public async Task<CommunityRoleForResultDto> RetrieveByIdAsync(short id)
    {
        var communityRole = await _repository.SelectAll()
            .Where(cr => cr.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (communityRole is null)
            throw new MDCException(404, "CommunityRole not found.");

        return _mapper.Map<CommunityRoleForResultDto>(communityRole);
    }
}
