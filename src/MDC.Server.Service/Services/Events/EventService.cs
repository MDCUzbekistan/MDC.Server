using AutoMapper;
using MDC.Server.Data.IRepositories;
using MDC.Server.Domain.Entities.Events;
using MDC.Server.Service.DTOs.Events;
using MDC.Server.Service.Interfaces.Events;

namespace MDC.Server.Service.Services.Events;

public class EventService : IEventService
{
    private readonly IMapper _mapper;
    private readonly IRepository<Event, long> _repository;
    public Task<EventForResultDto> CreateAsync(EventForCreationDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<EventForResultDto> ModifyAsync(long id, EventForUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoveAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<EventForResultDto>> RetrieveAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<EventForResultDto> RetrieveByIdAsync(long id)
    {
        throw new NotImplementedException();
    }
}
