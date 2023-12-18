using MDC.Server.Domain.Enums;
using MDC.Server.Domain.Commons;
using MDC.Server.Domain.Entities.Users;

namespace MDC.Server.Domain.Entities.Events
{
    public class Event : Auditable<long>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public EventFormat Format { get; set; }
        public EventStatus Status { get; set; }
        public string Banner { get; set; }

        public long? LocationId { get; set; }
        //public Location Location { get; set; }
        public string LiveStreamUrl { get; set; }
        public DateTime? StartAt { get; set; }
        public DateTime? EndAt { get; set; }

        public ICollection<UserEvent> Users { get; set; }
        public ICollection<EventSession> Sessions { get; set; }
    }
}
