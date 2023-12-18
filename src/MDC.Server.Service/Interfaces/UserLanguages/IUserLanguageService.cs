using MDC.Server.Domain.Configurations;
using MDC.Server.Service.DTOs.UserLanguages;

namespace MDC.Server.Service.Interfaces.UserLanguages;

public interface IUserLanguageService
{
    Task<bool> RemoveAsync(long id);
    Task<UserLanguageForResultDto> RetrieveByIdAsync(long id);
    Task<UserLanguageForResultDto> AddAsync(UserLanguageForCreationDto dto);
    Task<UserLanguageForResultDto> ModifyAsync(long id, UserLanguageForUpdateDto dto);
    Task<IEnumerable<UserLanguageForResultDto>> RetrieveAllAsync(PaginationParams @params);
}
