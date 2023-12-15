using AutoMapper;
using MDC.Server.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using MDC.Server.Data.IRepositories;
using MDC.Server.Service.Exceptions;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Service.DTOs.UserEvents;

namespace MDC.Server.Service.Services;

public class UserEventService : IUserEventService
{
    private readonly IMapper _mapper;
    private readonly IRepository<UserEvent, long> _userEventRepository;

    public UserEventService(
        IMapper mapper,
        IRepository<UserEvent, long> userEventRepository)
    {
        this._mapper = mapper;
        this._userEventRepository = userEventRepository;
    }

    public async Task<UserEventForResultDto> AddAsync(UserEventForCreationDto dto)
    {
        var data = this._userEventRepository
            .SelectAll()
            .Where(u => u.UserId == dto.UserId && u.EventId == dto.EventId && u.RoleId == dto.RoleId)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if(data is not null)
            throw new MDCException(409, "UserEvent is already exist");

        var createdData = await this._userEventRepository.InsertAsync(this._mapper.Map<UserEvent>(dto));
        createdData.CreatedAt = DateTime.UtcNow;

        return this._mapper.Map<UserEventForResultDto>(createdData);
    }

    public async Task<UserEventForResultDto> ModifyAsync(long id, UserEventForUpdateDto dto)
    {
        var data = await this._userEventRepository
            .SelectAll()
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();
        if(data is null)
            throw new MDCException(404,"UserEvent is not found");

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