using MDC.Server.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDC.Server.Domain.Entities.Users
{
    public class SpeakerDetail : Auditable<long>
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public short ExperienceYear { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string SpeechImage { get; set; }
    }
}
