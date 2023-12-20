using MDC.Server.Domain.Configurations;
using MDC.Server.Service.DTOs.Community;
using MDC.Server.Service.DTOs.CommunityRoles;
using MDC.Server.Service.DTOs.UserCommunities;
using Microsoft.AspNetCore.Mvc;

namespace MDC.Server.Api.Controllers.UserCommunities;

public class UserCommunitiesController : BaseController
{
    private readonly IUserCommunityService _userCommunityService;

    public UserCommunitiesController(IUserCommunityService userCommunityService)
    {
        _userCommunityService = userCommunityService;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] UserCommunityForCreationDto dto)
        => Ok(await this._userCommunityService.CreateAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
        => Ok(await this._userCommunityService.RetrieveAllAsync(@params));

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] short id)
        => Ok(await this._userCommunityService.RetrieveByIdAsync(id));


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] short id)
        => Ok(await this._userCommunityService.RemoveAsync(id));


    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] short id, [FromBody] UserCommunityForUpdateDto dto)
        => Ok(await this._userCommunityService.ModifyAsync(id, dto));
}
