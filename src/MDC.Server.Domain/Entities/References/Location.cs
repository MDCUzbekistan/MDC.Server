using MDC.Server.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDC.Server.Domain.Entities.References
{
    public class Location : Auditable<long>
    {
        public long Longitude { get; set; }
        public long Latitude { get; set; }
        public string Address { get; set; }
    }
}
