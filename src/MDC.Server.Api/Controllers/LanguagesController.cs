using MDC.Server.Domain.Configurations;
using MDC.Server.Service.DTOs.Languages;
using MDC.Server.Service.Interfaces.Languages;
using Microsoft.AspNetCore.Mvc;

namespace MDC.Server.Api.Controllers;

public class LanguagesController : BaseController
{
    private readonly ILanguageService _languageService;

    public LanguagesController(ILanguageService languageService)
    {
        _languageService = languageService;
    }

    [HttpPost]
    public async Task<IActionResult> InsertAsync([FromBody] LanguageForCreationDto dto)
        => Ok(await _languageService.CreateAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
        => Ok(await _languageService.RetrieveAllAsync(@params));

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] short id)
        => Ok(await _languageService.RetrieveByIdAsync(id));

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveAsync([FromRoute] short id)
        => Ok(await _languageService.RemoveAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync([FromRoute] short id, [FromBody] LanguageForUpdateDto dto)
        => Ok(await _languageService.ModifyAsync(id, dto));
}