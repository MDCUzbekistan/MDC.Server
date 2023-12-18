using AutoMapper;
using MDC.Server.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using MDC.Server.Data.IRepositories;
using MDC.Server.Service.Exceptions;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Domain.Configurations;
using MDC.Server.Service.DTOs.UserEvents;
using MDC.Server.Service.Commons.Extensions;

namespace MDC.Server.Service.Services;

public class UserEventService : IUserEventService
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;
    private readonly IEventRepository _eventRepository;
    private readonly IEventRoleRepository _eventRoleRepository;
    private readonly IUserEventRepository _userEventRepository;

    public UserEventService(
        IMapper mapper,
        IUserRepository userRepository,
        IEventRepository eventRepository,
        IEventRoleRepository eventRoleRepository,
        IUserEventRepository userEventRepository)
    {
        this._mapper = mapper;
        this._userRepository = userRepository;
        this._eventRepository = eventRepository;
        this._eventRoleRepository = eventRoleRepository;
        this._userEventRepository = userEventRepository;
    }

    public async Task<UserEventForResultDto> AddAsync(UserEventForCreationDto dto)
    {
        var userData = await this._userRepository
            .SelectAll()
            .Where(u => u.Id == dto.UserId)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (userData is null)
            throw new MDCException(404, "User is not found");

        var evetData = await this._eventRepository
             .SelectAll()
             .Where(e => e.Id == dto.EventId)
             .AsNoTracking()
             .FirstOrDefaultAsync();
        if (evetData is null)
            throw new MDCException(404, "Event is not found");

        var eventRoleData = await this._eventRoleRepository
            .SelectAll()
            .Where(e => e.Id == dto.RoleId)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (eventRoleData is null)
            throw new MDCException(404, "Role is not found");

        var mappedData = this._mapper.Map<UserEvent>(dto);
        mappedData.CreatedAt = DateTime.UtcNow;
        var createdData = await this._userEventRepository.InsertAsync(mappedData);

        return this._mapper.Map<UserEventForResultDto>(createdData);
    }

    public async Task<UserEventForResultDto> ModifyAsync(long id, UserEventForUpdateDto dto)
    {
        var data = await this._userEventRepository
            .SelectAll()
            .Where(u => u.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if(data is null)
            throw new MDCException(404,"UserEvent is not found");

        var user = await this._userRepository
            .SelectAll()
            .Where(u => u.Id == dto.UserId)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (user is null)
            throw new MDCException(404, "User is not found");

        var evetData = await this._eventRepository
             .SelectAll()
             .Where(e => e.Id == dto.EventId)
             .AsNoTracking()
             .FirstOrDefaultAsync();
        if (evetData is null)
            throw new MDCException(404, "Event is not found");

        var eventRoleData = await this._eventRoleRepository
            .SelectAll()
            .Where(e => e.Id == dto.RoleId)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (eventRoleData is null)
            throw new MDCException(404, "Role is not found");

        var mappedData = this._mapper.Map(dto, data);
        mappedData.UpdatedAt = DateTime.UtcNow; 
        await this._userEventRepository.UpdateAsync(mappedData);
        return this._mapper.Map<UserEventForResultDto>(mappedData);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var data = await this._userEventRepository
            .SelectAll()
            .Where(u => u.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync(); 
        if(data is null)
            throw new MDCException(404,"UserEvent is not found");

        return await this._userEventRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<UserEventForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var data = await this._userEventRepository
            .SelectAll()
            .Include(u => u.User)
            .Include(u => u.Event)
            .Include(u => u.Role)
            .AsNoTracking()
            .ToPagedList(@params)
            .ToListAsync();
        if(data is null)
            throw new MDCException(404,"Data are not found");

        return this._mapper.Map<IEnumerable<UserEventForResultDto>>(data);
    }

    public async Task<UserEventForResultDto> RetrieveByIdAsync(long id)
    {
        var data = await this._userEventRepository
            .SelectAll()
            .Where(u => u.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (data is null)
            throw new MDCException(404,"UserEvent is not found");

        return this._mapper.Map<UserEventForResultDto>(data); 
    }
}