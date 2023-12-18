using Microsoft.AspNetCore.Mvc;
using MDC.Server.Service.DTOs.EventAssets;
using MDC.Server.Service.Interfaces.Events;

namespace MDC.Server.Api.Controllers.Events;

public class EventAssetsController : BaseController
{
    private readonly IEventAssetService _eventAssetService;

    public EventAssetsController(IEventAssetService eventAssetService)
    {
        _eventAssetService = eventAssetService;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromForm] EventAssetForCreationDto dto)
       => Ok(await this._eventAssetService.CreateAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await _eventAssetService.RetrieveAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._eventAssetService.RetrieveByIdAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromForm] EventAssetForUpdateDto dto)
        => Ok(await this._eventAssetService.ModifyAsync(id, dto));

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._eventAssetService.RemoveAsync(id));
}
