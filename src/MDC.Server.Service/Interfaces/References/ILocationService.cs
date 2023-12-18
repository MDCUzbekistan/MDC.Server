using MDC.Server.Service.DTOs.Location;

namespace MDC.Server.Service.Interfaces.References;

public interface ILocationService
{
    Task<bool> RemoveAsync(short id);
    Task<LocationForResultDto> RetrieveByIdAsync(short id);
    Task<LocationForResultDto> CreateAsync(LocationForCreationDto dto);
    Task<LocationForResultDto> ModifyAsync(short id, LocationForUpdateDto dto);
}
