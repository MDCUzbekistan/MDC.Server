using MDC.Server.Domain.Configurations;
using MDC.Server.Service.DTOs.Languages;

namespace MDC.Server.Service.Interfaces.Languages;

public interface ILanguageService
{
    Task<bool> RemoveAsync(short id);
    Task<LanguageForResultDto> RetrieveByIdAsync(short id);
    Task<LanguageForResultDto> CreateAsync(LanguageForCreationDto dto);
    Task<LanguageForResultDto> ModifyAsync(short id, LanguageForUpdateDto dto);

    Task<IEnumerable<LanguageForResultDto>> RetrieveAllAsync(PaginationParams @params);
}
