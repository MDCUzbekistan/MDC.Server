using MDC.Server.Domain.Commons;

namespace MDC.Server.Domain.Entities.Events;

public class EventAsset : Auditable<long>
{
    public long EventId { get; set; }
    public Event Event { get; set; }
    public string Image { get; set; }

}
