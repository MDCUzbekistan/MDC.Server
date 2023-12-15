using MDC.Server.Domain.Entities.Events;
using MDC.Server.Domain.Entities.References;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Domain.Enums;

namespace MDC.Server.Service.DTOs.Events;

public class EventForResultDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public EventFormat Format { get; set; }
    public EventStatus Status { get; set; }
    public string Banner { get; set; }

    public long? LocationId { get; set; }
    public string LiveStreamUrl { get; set; }
    public DateTime? StartAt { get; set; }
    public DateTime? EndAt { get; set; }

    public ICollection<UserEvent> Users { get; set; }
    public ICollection<EventSession> Sessions { get; set; }
}
