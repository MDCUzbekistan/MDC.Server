using MDC.Server.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDC.Server.Domain.Entities.Communities
{
    public class Community : Auditable<long>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Bio { get; set; }

        public string Banner { get; set; }
        public string Logo { get; set; }

        public long? ParentId { get; set; }
        
        

    }
}
