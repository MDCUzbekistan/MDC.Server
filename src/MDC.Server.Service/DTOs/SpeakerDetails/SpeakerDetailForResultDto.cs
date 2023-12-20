using MDC.Server.Service.DTOs.Users;

namespace MDC.Server.Service.DTOs.SpeakerDetails
{
    public class SpeakerDetailForResultDto
    {
        public long Id { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string SpeechImage { get; set; }
        public short ExperienceYear { get; set; }
        public UserForResultDto User { get; set; }
    }
}
