using MDC.Server.Domain.Configurations;
using MDC.Server.Service.DTOs.Events;
using MDC.Server.Service.Interfaces.Events;
using Microsoft.AspNetCore.Mvc;

namespace MDC.Server.Api.Controllers.Events
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly IEventService _eventService;

        public EventsController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromForm] EventForCreationDto dto)
        => Ok(await this._eventService.CreateAsync(dto));

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
            => Ok(await _eventService.RetrieveAllAsync(@params));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
            => Ok(await this._eventService.RetrieveByIdAsync(id));

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromForm] EventForUpdateDto dto)
            => Ok(await this._eventService.ModifyAsync(id, dto));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
            => Ok(await this._eventService.RemoveAsync(id));

    }
}
