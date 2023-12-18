using MDC.Server.Domain.Entities.Events;

namespace MDC.Server.Service.DTOs.EventAssets;

public class EventAssetForResultDto
{
    public long Id { get; set; }
    public long EventId { get; set; }
    public string Image { get; set; }
}
