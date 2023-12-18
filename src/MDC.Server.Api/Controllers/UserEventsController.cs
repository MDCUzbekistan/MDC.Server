using Microsoft.AspNetCore.Mvc;
using MDC.Server.Service.Interfaces;
using MDC.Server.Domain.Configurations;
using MDC.Server.Service.DTOs.UserEvents;

namespace MDC.Server.Api.Controllers;

    [ApiController]
    [Route("api/[controller]")]
public class UserEventsController : ControllerBase
{
    private readonly IUserEventService _userEventService;

    public UserEventsController(IUserEventService userEventService)
    {
        this._userEventService = userEventService;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] UserEventForCreationDto dto)
       => Ok(await this._userEventService.AddAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
        => Ok(await this._userEventService.RetrieveAllAsync(@params));

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._userEventService.RetrieveByIdAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] UserEventForUpdateDto dto)
        => Ok(await this._userEventService.ModifyAsync(id, dto));

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
       => Ok(await this._userEventService.RemoveAsync(id));
}
