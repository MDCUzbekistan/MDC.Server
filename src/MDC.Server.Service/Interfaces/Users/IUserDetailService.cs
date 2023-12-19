using MDC.Server.Domain.Configurations;
using MDC.Server.Service.DTOs.UserDetails;

namespace MDC.Server.Service.Interfaces.Users;

public interface IUserDetailService
{
    Task<bool> RemoveAsync(long id);
    Task<UserDetailForResultDto> RetrieveByIdAsync(long id);
    Task<UserDetailForResultDto> CreateAsync(UserDetailForCreationDto dto);
    Task<UserDetailForResultDto> ModifyAsync(long id, UserDetailForUpdateDto dto);
    Task<IEnumerable<UserDetailForResultDto>> RetrieveAllAsync(PaginationParams @params);
}
