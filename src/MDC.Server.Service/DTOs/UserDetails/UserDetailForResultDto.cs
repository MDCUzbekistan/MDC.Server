using MDC.Server.Domain.Entities.Users;
using MDC.Server.Service.DTOs.Users;

namespace MDC.Server.Service.DTOs.UserDetails;

public class UserDetailForResultDto
{
    public long Id { get; set; }
    public string Image { get; set; }
    public string Resume { get; set; }
}
