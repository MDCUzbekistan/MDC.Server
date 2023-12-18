using MDC.Server.Domain.Entities.Users;
using MDC.Server.Domain.Entities.Events;

namespace MDC.Server.Service.DTOs.UserEvents;

public class UserEventForResultDto
{
    public long Id { get; set; }
    public User User { get; set; }
    public Event Event { get; set; }
    public EventRole Role { get; set; }
}
