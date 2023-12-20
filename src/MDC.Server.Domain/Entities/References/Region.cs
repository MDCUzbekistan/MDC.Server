using MDC.Server.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDC.Server.Domain.Entities.References
{
    public class Region : Auditable<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
