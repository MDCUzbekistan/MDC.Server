using MDC.Server.Service.DTOs.UserDetails;

namespace MDC.Server.Service.Interfaces;

public interface IUserDetailService
{
    //Task<IEnumerable<UserDetailForResultDto>> RetrieveAllAsync(PaginationParams @params);
    Task<UserDetailForResultDto> ModifyAsync(long id, UserDetailForUpdateDto dto);
    Task<UserDetailForResultDto> CreateAsync(UserDetailForCreationDto dto);
    Task<UserDetailForResultDto> RetrieveByIdAsync(long id);
    Task<bool> RemoveAsync(long id);
}
