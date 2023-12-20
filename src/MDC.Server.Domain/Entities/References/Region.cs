using MDC.Server.Domain.Commons;

namespace MDC.Server.Domain.Entities.References
{
    public class Region : Auditable<int>
    {
        public string Country { get; set; }
        public string City { get; set; }
    }
}
