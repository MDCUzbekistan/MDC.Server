using MDC.Server.Service.DTOs.CommunityRoles;
using MDC.Server.Service.Interfaces.CommunityRoles;
using Microsoft.AspNetCore.Mvc;

namespace MDC.Server.Api.Controllers.CommunityRoles;

public class CommunityRolesController : BaseController
{
    private readonly ICommunityRoleService _communityRoleService;

    public CommunityRolesController(ICommunityRoleService communityRoleService)
    {
        _communityRoleService = communityRoleService;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] CommunityRoleForCreationDto dto)
        => Ok(await this._communityRoleService.CreateAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await this._communityRoleService.RetrieveAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] short id)
        => Ok(await this._communityRoleService.RetrieveByIdAsync(id));


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] short id)
        => Ok(await this._communityRoleService.RemoveAsync(id));


    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] short id, [FromBody] CommunityRoleForUpdateDto dto)
        => Ok(await this._communityRoleService.ModifyAsync(id, dto));
}
