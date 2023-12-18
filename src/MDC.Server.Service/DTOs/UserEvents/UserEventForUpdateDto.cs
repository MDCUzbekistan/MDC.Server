namespace MDC.Server.Service.DTOs.UserEvents;

public class UserEventForUpdateDto
{
    public string UserId { get; set; }
    public long EventId { get; set; }
    public short RoleId { get; set; }
}
