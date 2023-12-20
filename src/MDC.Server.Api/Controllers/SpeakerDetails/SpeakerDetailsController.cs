using MDC.Server.Service.DTOs.SpeakerDetails;
using MDC.Server.Service.Interfaces.SpeakerDetails;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> RetrieveAllAsync()
            => Ok(await _speakerDetailService.RetrieveAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> RetrieveByIdAsync([FromRoute] string id)
            => Ok(await _speakerDetailService.RetrieveByIdAsync(id));

        [HttpPut("{id}")]
        public async Task<IActionResult> ModifyAsync([FromRoute] string id, SpeakerDetailForUpdateDto dto)
           => Ok(await _speakerDetailService.ModifyAsync(id, dto));

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveAsync([FromRoute] string id)
            => Ok(await _speakerDetailService.RemoveAsync(id));

       
    }
}
