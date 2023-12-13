using MDC.Server.Domain.Commons;
using MDC.Server.Domain.Entities.Communities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDC.Server.Domain.Entities.Users
{
    public class UserCommunity : Auditable<long>
    {
        public long UserId { get; set; }
        public User User { get; set; }

        public long CommunityId { get; set; }
        public Community Community { get; set; }

        public short RoleId { get; set; }
        public CommunityRole Role { get; set; }
    }
}
