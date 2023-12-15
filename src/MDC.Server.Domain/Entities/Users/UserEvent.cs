using MDC.Server.Domain.Commons;
using MDC.Server.Domain.Entities.Events;

namespace MDC.Server.Domain.Entities.Users
{
    public class UserEvent : Auditable<long>
    {
        public long UserId { get; set; }
        public User User { get; set; }

        public long EventId { get; set; }
        public Event Event { get; set; }

        public short RoleId { get; set; }
        public EventRole Role { get; set; }
    }
}
