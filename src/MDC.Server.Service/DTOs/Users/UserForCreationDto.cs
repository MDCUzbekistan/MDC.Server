
using MDC.Server.Service.Helpers;
using System.ComponentModel.DataAnnotations;

namespace MDC.Server.Service.DTOs.Users;
public class UserForCreationDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    [MDCEmailAttribute]
    public string Email { get; set; }
    [PhoneAttribute]
    public string PhoneNumber { get; set; }
    public string Password { get; set; }

    public DateTime? DateOfBirth { get; set; }
}
