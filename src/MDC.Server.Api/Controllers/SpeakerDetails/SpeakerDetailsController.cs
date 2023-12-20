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

        public SpeakerDetailsController(ISpeakerDetailService speakerDetailService)
        {
            _speakerDetailService = speakerDetailService;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromForm] SpeakerDetailForCreationDto dto)
            => Ok(await this._speakerDetailService.AddAsync(dto));

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
            => Ok(await this._speakerDetailService.RetrieveAllAsync(@params));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
            => Ok(await this._speakerDetailService.RetrieveByIdAsync(id));

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromForm] SpeakerDetailForUpdateDto dto)
           => Ok(await this._speakerDetailService.ModifyAsync(id, dto));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
            => Ok(await this._speakerDetailService.RemoveAsync(id));  
    }
}
