using MDC.Server.Domain.Configurations;
using MDC.Server.Service.DTOs.Regions;
using MDC.Server.Service.Interfaces.Regions;
using Microsoft.AspNetCore.Mvc;

namespace MDC.Server.Api.Controllers.Regions;

public class RegionsController : BaseController
{
    private readonly IRegionService _regionService;

    public RegionsController(IRegionService regionService)
    {
        _regionService = regionService;
    }

    [HttpPost]
    public async Task<IActionResult> InsertAsync([FromBody] RegionForCreationDto dto)
        => Ok(await _regionService.CreateAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
        => Ok(await _regionService.RetrieveAllAsync(@params));

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        => Ok(await _regionService.RetrieveByIdAsync(id));

    [HttpGet("search/{country}")]
    public async Task<IActionResult> GetByCountryAsync([FromRoute] string country)
        => Ok(await _regionService.RetrieveByCountryAsync(country));

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveAsync([FromRoute] int id)
        => Ok(await _regionService.RemoveAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync([FromRoute] int id, [FromBody] RegionForUpdateDto dto)
        => Ok(await _regionService.ModifyAsync(id, dto));
}
