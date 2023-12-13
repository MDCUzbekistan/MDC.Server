using MDC.Server.Domain.Commons;
using MDC.Server.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDC.Server.Domain.Entities.Events
{
    public class EventRole : Auditable<short>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
