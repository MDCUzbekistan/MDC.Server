using MDC.Server.Domain.Configurations;
using MDC.Server.Service.DTOs.UserLanguages;
using MDC.Server.Service.Interfaces.UserLanguages;
using Microsoft.AspNetCore.Mvc;

namespace MDC.Server.Api.Controllers
{
    public class UserLanguagesController : BaseController
    {
        readonly IUserLanguageService _userLanguageService;

        public UserLanguagesController(IUserLanguageService userLanguageService)
        {
            _userLanguageService = userLanguageService;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] UserLanguageForCreationDto dto)
             => Ok(await _userLanguageService.AddAsync(dto));

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
            => Ok(await _userLanguageService.RetrieveAllAsync(@params));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
            => Ok(await _userLanguageService.RetrieveByIdAsync(id));

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] UserLanguageForUpdateDto dto)
            => Ok(await _userLanguageService.ModifyAsync(id, dto));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
           => Ok(await _userLanguageService.RemoveAsync(id));
    }
}
