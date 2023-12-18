using MDC.Server.Service.DTOs.Users;
using MDC.Server.Service.DTOs.Events;
using MDC.Server.Service.DTOs.EventRoles;

namespace MDC.Server.Service.DTOs.UserEvents;

public class UserEventForResultDto
{
    public long Id { get; set; }
    public UserForCreationDto User { get; set; }
    public EventForCreationDto Event { get; set; }
    public EventRoleForCreationDto Role { get; set; }
}
