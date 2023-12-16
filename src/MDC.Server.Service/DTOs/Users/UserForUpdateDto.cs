using MDC.Server.Service.Helpers;
using System.ComponentModel.DataAnnotations;

namespace MDC.Server.Service.DTOs.Users;
public class UserForUpdateDto
{
    [Required,MinLength(3)]
    public string FirstName { get; set; }

    [Required,MinLength(3)]
    public string LastName { get; set; }

    [MDCEmailAttribute]
    public string Email { get; set; }
    [PhoneAttribute]
    public string PhoneNumber { get; set; }
    public DateTime? DateOfBirth { get; set; }
}
