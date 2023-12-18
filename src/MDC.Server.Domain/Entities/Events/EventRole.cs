using MDC.Server.Domain.Commons;
namespace MDC.Server.Domain.Entities.Events
{
    public class EventRole : Auditable<short>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
