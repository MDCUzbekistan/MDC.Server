using MDC.Server.Domain.Configurations;
using MDC.Server.Service.DTOs.UserEvents;

namespace MDC.Server.Service.Interfaces;

public interface IUserEventService
{
    Task<bool> RemoveAsync(long id);
    Task<UserEventForResultDto> RetrieveByIdAsync(long id);
    Task<UserEventForResultDto> AddAsync(UserEventForCreationDto dto);
    Task<UserEventForResultDto> ModifyAsync(long id, UserEventForUpdateDto dto);
    Task<IEnumerable<UserEventForResultDto>> RetrieveAllAsync(PaginationParams @params);
}
