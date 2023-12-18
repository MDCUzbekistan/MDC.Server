using MDC.Server.Service.DTOs.Events;
using MDC.Server.Domain.Configurations;

namespace MDC.Server.Service.Interfaces.Events;

public interface IEventService
{
    Task<bool> RemoveAsync(long id);
    Task<EventForResultDto> RetrieveByIdAsync(long id);
    Task<EventForResultDto> CreateAsync(EventForCreationDto dto);
    Task<EventForResultDto> ModifyAsync(long id, EventForUpdateDto dto);
    Task<IEnumerable<EventForResultDto>> RetrieveAllAsync(PaginationParams @params);
}
