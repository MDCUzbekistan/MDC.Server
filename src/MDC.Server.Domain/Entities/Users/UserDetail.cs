using MDC.Server.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDC.Server.Domain.Entities.Users
{
    public class UserDetail : Auditable<long>
    {
        public string UserId { get; set; }
        public User User { get; set; }  

        public string Image { get; set; }
        public string Resume { get; set; }
    }
}
