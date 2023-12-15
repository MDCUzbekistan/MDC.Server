using MDC.Server.Service.DTOs.Events;

namespace MDC.Server.Service.Interfaces.Events;

public interface IEventService
{
    Task<bool> RemoveAsync(long id);
    Task<EventForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<EventForResultDto>> RetrieveAllAsync();
    Task<EventForResultDto> CreateAsync(EventForCreationDto dto);
    Task<EventForResultDto> ModifyAsync(long id, EventForUpdateDto dto);
}
