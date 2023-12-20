using Microsoft.AspNetCore.Http;

namespace MDC.Server.Service.DTOs.SpeakerDetails
{
    public class SpeakerDetailForCreationDto
    {
        public string UserId { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public short ExperienceYear { get; set; }
        public IFormFile SpeechImage { get; set; }
    }
}
