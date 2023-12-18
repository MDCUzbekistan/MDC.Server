using MDC.Server.Domain.Entities.Users;
using Microsoft.AspNetCore.Http;

namespace MDC.Server.Service.DTOs.UserDetails;

public class UserDetailForCreationDto
{
    public long UserId { get; set; }
    public IFormFile Image { get; set; }
    public IFormFile Resume { get; set; }
}
