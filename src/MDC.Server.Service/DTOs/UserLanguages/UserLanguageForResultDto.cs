using MDC.Server.Service.DTOs.Languages;
using MDC.Server.Service.DTOs.Users;

namespace MDC.Server.Service.DTOs.UserLanguages;

public class UserLanguageForResultDto
{
    public long Id { get; set; }
    public UserForResultDto User { get; set; }
    public LanguageForResultDto Language { get; set; }
}
