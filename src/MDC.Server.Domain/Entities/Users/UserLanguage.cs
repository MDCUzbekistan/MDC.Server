using MDC.Server.Domain.Commons;
using MDC.Server.Domain.Entities.References;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MDC.Server.Domain.Entities.Users
{
    public class UserLanguage : Auditable<long>
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public short LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
