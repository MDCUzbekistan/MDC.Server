using AutoMapper;
using MDC.Server.Service.Interfaces;
using MDC.Server.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using MDC.Server.Service.Exceptions;
using MDC.Server.Domain.Configurations;
using MDC.Server.Domain.Entities.Events;
using MDC.Server.Service.DTOs.EventRoles;

namespace MDC.Server.Service.Services;

public class EventRoleService : IEventRoleService
{
    private readonly IMapper _mapper;
    private readonly IEventRoleRepository _eventRoleRepository;

    public EventRoleService(
        IMapper mapper,
        IEventRoleRepository eventRoleRepository)
    {
        this._mapper = mapper;
        this._eventRoleRepository = eventRoleRepository;
    }

    public async Task<EventRoleForResultDto> AddAsync(EventRoleForCreationDto dto)
    {
        var data = await this._eventRoleRepository
            .SelectAll()
            .Where(e => e.Name.ToLower() == dto.Name.ToLower())
            .FirstOrDefaultAsync();
        if(data is not null)
            throw new MDCException(409,"EventRole is already exist");

        var mappedData = this._mapper.Map<EventRole>(dto);
        mappedData.CreatedAt = DateTime.UtcNow;
        var createdData = await this._eventRoleRepository.InsertAsync(mappedData);

        return this._mapper.Map<EventRoleForResultDto>(createdData);
    }

    public async Task<EventRoleForResultDto> ModifyAsync(short id, EventRoleForUpdateDto dto)
    {
        var data = await this._eventRoleRepository
            .SelectAll()
            .Where(e => e.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if(data is null)
            throw new MDCException(404,"EventRole is not found");

        var mappedData = this._mapper.Map(dto, data);
        mappedData.UpdatedAt = DateTime.UtcNow;
        await this._eventRoleRepository.UpdateAsync(mappedData);
        return this._mapper.Map<EventRoleForResultDto>(mappedData);
    }

    public async Task<bool> RemoveAsync(short id)
    {
        var data = await this._eventRoleRepository
            .SelectAll()
            .Where(e => e.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if(data is null)    
            throw new MDCException(404,"EventRole is not found");
        return await this._eventRoleRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<EventRoleForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var data = await this._eventRoleRepository
            .SelectAll()
            .AsNoTracking()
            .ToListAsync();

        return this._mapper.Map<IEnumerable<EventRoleForResultDto>>(data);
    }

    public async Task<EventRoleForResultDto> RetrieveByIdAsync(short id)
    {
        var data = await this._eventRoleRepository
            .SelectAll()
            .Where(e => e.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if(data is null)
            throw new MDCException(404,"EventRole is not found");

        return this._mapper.Map<EventRoleForResultDto>(data);
    }
}
