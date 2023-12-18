using MDC.Server.Domain.Configurations;
using MDC.Server.Service.DTOs.EventAssets;
using MDC.Server.Service.DTOs.Events;

namespace MDC.Server.Service.Interfaces.Events;

public interface IEventAssetService
{
    Task<bool> RemoveAsync(long id);
    Task<EventAssetForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<EventAssetForResultDto>> RetrieveAllAsync();
    Task<EventAssetForResultDto> CreateAsync(EventAssetForCreationDto dto);
    Task<EventAssetForResultDto> ModifyAsync(long id, EventAssetForUpdateDto dto);
}
