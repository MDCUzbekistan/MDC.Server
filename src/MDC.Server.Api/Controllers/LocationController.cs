using MDC.Server.Service.DTOs.Location;
using MDC.Server.Service.Interfaces.References;
using Microsoft.AspNetCore.Mvc;

namespace MDC.Server.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LocationController : ControllerBase
{
    private readonly ILocationService _locationService;

    public LocationController(ILocationService locationService)
    {
        _locationService = locationService;
    }

    [HttpPost]
    public async Task<IActionResult> InsertAsync([FromBody] LocationForCreationDto dto)
        => Ok(await _locationService.CreateAsync(dto));

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] short id)
        => Ok(await _locationService.RetrieveByIdAsync(id));

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveAsync([FromRoute] short id)
        => Ok(await _locationService.RemoveAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync([FromRoute] short id, [FromBody] LocationForUpdateDto dto)
        => Ok(await _locationService.ModifyAsync(id, dto));
}
