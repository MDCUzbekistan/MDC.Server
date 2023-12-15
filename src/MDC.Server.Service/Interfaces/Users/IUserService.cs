using MDC.Server.Service.DTOs.Users;

namespace MDC.Server.Service.Interfaces.Users;
public interface IUserService
{
    Task<bool> DeleteAsync(long id);
    Task<UserForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<UserForResultDto>> RetrieveAllAsync();
    Task<UserForResultDto> RetrieveByEmailAsync(string email);
    Task<UserForResultDto> AddAsync(UserForCreationDto user);
    Task<UserForResultDto> ModifyAsync(long id,UserForUpdateDto user);
}
