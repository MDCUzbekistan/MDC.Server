using Microsoft.AspNetCore.Mvc;
using MDC.Server.Service.DTOs.SpeakerDetails;
using MDC.Server.Service.Interfaces.SpeakerDetails;

namespace MDC.Server.Api.Controllers.SpeakerDetails
{
    public class SpeakerDetailsController : BaseController
    {
        private readonly Service.Interfaces.SpeakerDetails.ISpeakerDetailService _speakerDetailService;

        public SpeakerDetailsController(ISpeakerDetailService speakerDetailService)
        {
            _speakerDetailService = speakerDetailService;
        }

        [HttpPost]
        public async Task<IActionResult> InsertAsync([FromBody] SpeakerDetailForCreationDto dto)
          => Ok(await _speakerDetailService.AddAsync(dto));
       
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
          => Ok(await _speakerDetailService.RetrieveAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromBody] long id)
            => Ok(await _speakerDetailService.RetrieveByIdAsync(id));

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveAsync([FromBody] long id)
            => Ok(await _speakerDetailService.RemoveAsync(id));

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync([FromBody] long id, [FromBody] SpeakerDetailForUpdateDto dto)
            => Ok(await _speakerDetailService.ModifyAsync(id,dto));

    }
}
