using Microsoft.AspNetCore.Http;

namespace MDC.Server.Service.DTOs.UserDetails;

public class UserDetailForUpdateDto
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public IFormFile Image { get; set; }
    public IFormFile Resume { get; set; }
}
