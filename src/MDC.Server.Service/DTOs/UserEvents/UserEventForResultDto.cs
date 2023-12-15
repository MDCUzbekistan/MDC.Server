using MDC.Server.Domain.Entities.Users;
using MDC.Server.Domain.Entities.Events;

namespace MDC.Server.Service.DTOs.UserEvents;

public class UserEventForResultDto
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }
    public long EventId { get; set; }
    public Event Event { get; set; }
    public short RoleId { get; set; }
    public EventRole Role { get; set; }
}
