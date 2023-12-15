using AutoMapper;
using MDC.Server.Service.Interfaces;
using MDC.Server.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using MDC.Server.Service.Exceptions;
using MDC.Server.Domain.Entities.Events;
using MDC.Server.Service.DTOs.EventRoles;
using Microsoft.VisualBasic;

namespace MDC.Server.Service.Services;

public class EventRoleService : IEventRoleService
{
    private readonly IMapper _mapper;
    private readonly IRepository<EventRole, short> _eventRoleRepository;

    public EventRoleService(
        IMapper mapper,
        IRepository<EventRole, short> eventRoleRepository)
    {
        this._mapper = mapper;
        this._eventRoleRepository = eventRoleRepository;
    }

    public async Task<EventRoleForResultDto> AddAsync(EventRoleForCreationDto dto)
    {
        var data = await this._eventRoleRepository
            .SelectAll()
            .Where(e => e.Name.ToLower() == dto.Name.ToLower())
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if(data is not null)
            throw new MDCException(409,"EventRole is already exist");

        var createdData = await this._eventRoleRepository.InsertAsync(this._mapper.Map<EventRole>(dto));
        createdData.CreatedAt = DateTime.UtcNow;

        return this._mapper.Map<EventRoleForResultDto>(createdData);
    }

    public async Task<EventRoleForResultDto> ModifyAsync(long id, EventRoleForUpdateDto dto)
    {
        var data = await this._eventRoleRepository
            .SelectAll()
            .Where(e => e.Id == id)
            .FirstOrDefaultAsync();
        if(data is null)
            throw new MDCException(404,"EventRole is not found");

        var mappedData = this._mapper.Map(dto, data);
        mappedData.UpdatedAt = DateTime.UtcNow;
        await this._eventRoleRepository.InsertAsync(mappedData);
        return this._mapper.Map < EventRoleForResultDto>(mappedData);
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
        if(data is null)
            throw new MDCException(404,"EventRoles are not found");

        return this._mapper.Map<EventRoleForResultDto>(data);
    }

    public Task<EventRoleForResultDto> RetrieveByIdAsync(long id)
    {

        throw new NotImplementedException();
    }
}
