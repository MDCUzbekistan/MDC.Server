using MDC.Server.Domain.Entities.References;
using MDC.Server.Domain.Entities.Users;

namespace MDC.Server.Service.DTOs.UserLanguages;

public class UserLanguageForCreationDto
{
    public long UserId { get; set; }
    public short LanguageId { get; set; }
}
