using MDC.Server.Service.DTOs.Community;
using MDC.Server.Service.Interfaces.Community;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Writers;

namespace MDC.Server.Api.Controllers.Community;

public class CommunityController : BaseController
{
    private readonly ICommunityService _communityService;

    public CommunityController(ICommunityService communityService)
    {
        _communityService = communityService;
    }

    [HttpGet("{community-id}")]
    public async Task<IActionResult>GetByIdAsync([FromRoute(Name = "community-id")] long id)
        =>Ok(await _communityService.RetruveByIdAsync(id));

    [HttpGet]
    public async Task<IActionResult>GetAllAsync()
        =>Ok(await _communityService.RetruveAllAsync());

    [HttpDelete("{community-id}")]
    public async Task<IActionResult>DeleteAsync([FromRoute(Name = "community-id")] long id)
        =>Ok(await _communityService.DeleteAsync(id));

    [HttpPost]
    public async Task<IActionResult>CreateAsync(CommunityForCreationDto communityForCreationDto)
        =>Ok(await _communityService.CreateAsync(communityForCreationDto));

    [HttpPut]
    public async Task<IActionResult>UpdateAsync(CommunityForUpdateDto communityForUpdateDto)
        =>Ok(await _communityService.UpdateAsync(communityForUpdateDto));

    
}
