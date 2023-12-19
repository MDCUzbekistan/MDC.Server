using MDC.Server.Domain.Commons;
using MDC.Server.Domain.Entities.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDC.Server.Domain.Entities.Users
{
    public class UserEvent : Auditable<long>
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public long EventId { get; set; }
        public Event Event { get; set; }

        public short RoleId { get; set; }
        public EventRole Role { get; set; }
    }
}
