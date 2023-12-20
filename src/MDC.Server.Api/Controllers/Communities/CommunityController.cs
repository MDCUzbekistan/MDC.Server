using Microsoft.AspNetCore.Mvc;
using MDC.Server.Service.DTOs.Community;
using MDC.Server.Service.Interfaces.Communities;
using MDC.Server.Service.DTOs.CommunityImage;

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

        [HttpGet("GetById{community-id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute(Name = "community-id")] long Id)
            =>Ok(await _communityService.RetruveByIdAsync(Id));

        [HttpGet("GetAll")]
        public async Task<IActionResult>GeAllAsync()
            =>Ok(await _communityService.RetruveAllAsync());

        [HttpDelete("Delete/{community-id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute(Name = "community-id")] long id)
            =>Ok(await _communityService.DeleteAsync(id));

        [HttpPost("Create")]
        public async Task<IActionResult> CreateAsync([FromBody]CommunityForCreationDto community)
            =>Ok(await _communityService.CreateAsync(community));

        [HttpPut("Update/{community-id}")]
        public async Task<IActionResult> UpdateAsync([FromRoute(Name = "community-id")] long id, [FromBody]CommunityForUpdateDto community)
            =>Ok(await _communityService.UpdateAsync(id,community));


        [HttpPost("Create/Banner/{community-id}")]
        public async Task<IActionResult> CreateCommunityBannerAsync([FromRoute(Name = "community-id")] long id, [FromForm] CommunityImageForCreationDto file)
            => Ok(await _communityService.CreateBannerAsync(id,file));


        [HttpPost("Create/Logo/{community-id}")]
        public async Task<IActionResult> CreateCommunityLogoAsync([FromRoute(Name = "community-id")] long id, [FromForm] CommunityImageForCreationDto file)
            => Ok(await _communityService.CreateLogoAsync(id, file));

        [HttpPut("Update/Banner/{community-id}")]
        public async Task<IActionResult> UpdateCommunitBannerAsync([FromRoute(Name = "community-id")] long id, [FromForm] CommunityImageForCreationDto file)
           => Ok(await _communityService.UpdateBannerAsync(id, file));

        [HttpPut("Update/Logo/{community-id}")]
        public async Task<IActionResult> UpdateCommunityLogoAsync([FromRoute(Name = "community-id")] long id,[FromForm] CommunityImageForCreationDto file)
            => Ok(await _communityService.UpdateLogoAsync(id, file));

    }
}
