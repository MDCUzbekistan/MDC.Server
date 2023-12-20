using Microsoft.AspNetCore.Mvc;
using MDC.Server.Service.DTOs.Users;
using MDC.Server.Service.Interfaces.Users;

namespace MDC.Server.Api.Controllers.Users;

public class UsersController:BaseController
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    public async Task<IActionResult> InsertAsync([FromBody] UserForCreationDto dto)
        =>Ok(await _userService.CreateAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        =>Ok(await _userService.RetrieveAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] string id)
        =>Ok(await _userService.RetrieveByIdAsync(id));

    [HttpGet("email")]
    public async Task<IActionResult> GetByEmailAsync(string email)
        =>Ok(await _userService.RetrieveByEmailAsync(email));

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute] string id)
        =>Ok(await _userService.RemoveAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync([FromRoute] string id, [FromBody] UserForUpdateDto dto)
        =>Ok(await _userService.ModifyAsync(id, dto));
}
