using MDC.Server.Domain.Commons;
using MDC.Server.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDC.Server.Domain.Entities.Events
{
    public class EventSessionForResultDto : Auditable<long>
    {
        public long EventId { get; set; }
        public Event Event { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime? StartAt { get; set; }
        public DateTime? EndAt { get; set; }

        public string SpeakerId { get; set; }
        public User Speaker { get; set; }
    }
}
