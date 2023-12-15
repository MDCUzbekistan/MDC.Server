using Microsoft.AspNetCore.Mvc;
using MDC.Server.Service.Interfaces;
using MDC.Server.Domain.Configurations;
using MDC.Server.Service.DTOs.EventRoles;

namespace MDC.Server.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventRolesController : ControllerBase
    {
        private readonly IEventRoleService _eventRoleService;

        public EventRolesController(IEventRoleService eventRoleService)
        {
            this._eventRoleService = eventRoleService;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] EventRoleForCreationDto dto)
           => Ok(await this._eventRoleService.AddAsync(dto));

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
            => Ok(await this._eventRoleService.RetrieveAllAsync(@params));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] short id)
            => Ok(await this._eventRoleService.RetrieveByIdAsync(id));

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] short id, [FromBody] EventRoleForUpdateDto dto)
            => Ok(await this._eventRoleService.ModifyAsync(id, dto));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] short id)
           => Ok(await this._eventRoleService.RemoveAsync(id));
    }
}
