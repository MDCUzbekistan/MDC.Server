using MDC.Server.Domain.Commons;
using MDC.Server.Domain.Entities.Communities;

namespace MDC.Server.Domain.Entities.Users
{
    public class User : Auditable<long>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public UserDetail UserDetail { get; set; }

        public ICollection<UserCommunity> Communities { get; set; }
        public ICollection<UserEvent> Events { get; set; }
        public ICollection<UserLanguage> Languages { get; set; }
    }
}
