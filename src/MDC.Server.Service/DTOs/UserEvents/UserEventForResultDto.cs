using MDC.Server.Service.DTOs.Users;
using MDC.Server.Service.DTOs.Events;
using MDC.Server.Service.DTOs.EventRoles;

namespace MDC.Server.Service.DTOs.UserEvents;

public class UserEventForResultDto
{
    public long Id { get; set; }
    public UserForResultDto User { get; set; }
    public EventForResultDto Event { get; set; }
    public EventRoleForResultDto Role { get; set; }
}
