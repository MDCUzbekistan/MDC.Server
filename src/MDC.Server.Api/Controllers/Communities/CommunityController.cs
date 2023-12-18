using Microsoft.AspNetCore.Mvc;
using MDC.Server.Service.DTOs.Community;
using MDC.Server.Service.Interfaces.Communities;

namespace MDC.Server.Api.Controllers.Communities
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommunityController : ControllerBase
    {
        private readonly ICommunityService _communityService;

        public CommunityController(ICommunityService communityService)
        {
            _communityService = communityService;
        }

        [HttpGet("{community-id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute(Name = "community-id")] long Id)
            =>Ok(await _communityService.RetruveByIdAsync(Id));

        [HttpGet]
        public async Task<IActionResult>GeAllAsync()
            =>Ok(await _communityService.RetruveAllAsync());

        [HttpDelete("{community-id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute(Name = "community-id")] long id)
            =>Ok(await _communityService.DeleteAsync(id));

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody]CommunityForCreationDto community)
            =>Ok(await _communityService.CreateAsync(community));

        [HttpPut("{community-id}")]
        public async Task<IActionResult> UpdateAsync([FromRoute(Name = "community-id")] long Id,[FromBody]CommunityForUpdateDto community)
            =>Ok(await _communityService.UpdateAsync(Id,community));
        
    }
}
