using MDC.Server.Domain.Entities.Events;
using MDC.Server.Domain.Entities.References;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Domain.Enums;
using MDC.Server.Service.DTOs.UserEvents;

namespace MDC.Server.Service.DTOs.Events;

public class EventForResultDto
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public EventFormat Format { get; set; }
    public EventStatus Status { get; set; }

    public long? LocationId { get; set; }
    public string LiveStreamUrl { get; set; }
    public DateTime? StartAt { get; set; }
    public DateTime? EndAt { get; set; }

    public ICollection<UserEventForResultDto> Users { get; set; }
    public ICollection<EventSessionForResultDto> Sessions { get; set; }
}
