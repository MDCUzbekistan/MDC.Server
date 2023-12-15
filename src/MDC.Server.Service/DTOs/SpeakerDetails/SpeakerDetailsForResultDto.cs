using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDC.Server.Service.DTOs.SpeakerDetails
{
    public class SpeakerDetailsForResultDto
    {
        public long UserId { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string SpeechImage { get; set; }
        public short ExperienceYear { get; set; }
    }
}
