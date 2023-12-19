using Microsoft.AspNetCore.Http;

namespace MDC.Server.Service.DTOs.UserDetails;

public class UserDetailForCreationDto
{
    public string UserId { get; set; }
    public IFormFile Image { get; set; }
    public IFormFile Resume { get; set; }
}
