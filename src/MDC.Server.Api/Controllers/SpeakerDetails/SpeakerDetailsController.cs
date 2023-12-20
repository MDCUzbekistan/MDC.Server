using Microsoft.AspNetCore.Mvc;
using MDC.Server.Domain.Configurations;
using MDC.Server.Service.DTOs.SpeakerDetails;
using MDC.Server.Service.Interfaces.SpeakerDetails;

namespace MDC.Server.Api.Controllers.SpeakerDetails
{
    [ApiController]
    [Route("api/[controller]")]
    public class SpeakerDetailsController : ControllerBase
    {
        private readonly ISpeakerDetailService _speakerDetailService;

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] SpeakerDetailForCreationDto dto)
            => Ok(await _speakerDetailService.AddAsync(dto));

        [HttpGet]
        public async Task<IActionResult> RetrieveAllAsync([FromQuery] PaginationParams @params)
            => Ok(await _speakerDetailService.RetrieveAllAsync(@params));

        [HttpGet("{id}")]
        public async Task<IActionResult> RetrieveByIdAsync([FromRoute] long id)
            => Ok(await _speakerDetailService.RetrieveByIdAsync(id));

        [HttpPut("{id}")]
        public async Task<IActionResult> ModifyAsync([FromRoute] long id, SpeakerDetailForUpdateDto dto)
           => Ok(await _speakerDetailService.ModifyAsync(id, dto));

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveAsync([FromRoute] long id)
            => Ok(await _speakerDetailService.RemoveAsync(id));  
    }
}
