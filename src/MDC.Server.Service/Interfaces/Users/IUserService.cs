using MDC.Server.Domain.Configurations;
using MDC.Server.Service.DTOs.Users;

namespace MDC.Server.Service.Interfaces.Users;

public interface IUserService
{
    Task<bool> RemoveAsync(string id);
    Task<UserForResultDto> RetrieveByIdAsync(string id);
    Task<UserForResultDto> RetrieveByEmailAsync(string email);
    Task<IEnumerable<UserForResultDto>> RetrieveAllAsync(PaginationParams @params);
    Task<UserForResultDto> CreateAsync(UserForCreationDto dto);
    Task<UserForResultDto> ModifyAsync(string id, UserForUpdateDto dto);
}
