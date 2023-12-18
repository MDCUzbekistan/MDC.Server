using MDC.Server.Domain.Configurations;
using MDC.Server.Service.DTOs.EventRoles;

namespace MDC.Server.Service.Interfaces;

public interface IEventRoleService
{
    Task<bool> RemoveAsync(short id);
    Task<EventRoleForResultDto> RetrieveByIdAsync(short id);
    Task<EventRoleForResultDto> AddAsync(EventRoleForCreationDto dto);
    Task<EventRoleForResultDto> ModifyAsync(short id, EventRoleForUpdateDto dto);
    Task<IEnumerable<EventRoleForResultDto>> RetrieveAllAsync(PaginationParams @params);
}
