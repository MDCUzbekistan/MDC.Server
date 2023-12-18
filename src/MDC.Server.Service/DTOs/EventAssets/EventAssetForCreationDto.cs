using MDC.Server.Domain.Entities.Events;
using Microsoft.AspNetCore.Http;

namespace MDC.Server.Service.DTOs.EventAssets;

public class EventAssetForCreationDto
{
    public long EventId { get; set; }
    public IFormFile Image { get; set; }
}
