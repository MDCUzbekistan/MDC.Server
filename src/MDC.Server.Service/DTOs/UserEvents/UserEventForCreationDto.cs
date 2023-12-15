namespace MDC.Server.Service.DTOs.UserEvents;

public class UserEventForCreationDto
{
    public long UserId { get; set; }
    public long EventId { get; set; }
    public short RoleId { get; set; }
}
