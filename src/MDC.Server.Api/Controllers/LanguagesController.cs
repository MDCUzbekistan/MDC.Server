using MDC.Server.Domain.Configurations;
using MDC.Server.Service.DTOs.Languages;
using MDC.Server.Service.Interfaces.Languages;
using MDC.Server.Service.Interfaces.Users;
using Microsoft.AspNetCore.Mvc;

namespace MDC.Server.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LanguagesController : ControllerBase
{
    private readonly ILanguageService _LanguageService;

    public LanguagesController(ILanguageService languageService)
    {
        _LanguageService = languageService;
    }

    [HttpPost]
    public async Task<IActionResult> InsertAsync([FromBody] LanguageForCreationDto dto)
        => Ok(await _LanguageService.CreateAsync(dto));

    //[HttpGet]
    //public async Task<IActionResult> GetAllAsync(PaginationParams @params)
    //    => Ok(await _LanguageService.RetrieveAllAsync(@params));

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] short id)
        => Ok(await _LanguageService.RetrieveByIdAsync(id));

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveAsync([FromRoute] short id)
        => Ok(await _LanguageService.RemoveAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync([FromRoute] short id, [FromBody] LanguageForUpdateDto dto)
        => Ok(await _LanguageService.ModifyAsync(id, dto));
}