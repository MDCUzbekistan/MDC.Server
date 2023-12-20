using Microsoft.EntityFrameworkCore;
using MDC.Server.Domain.Entities.Users;

namespace MDC.Server.Data.DbContexts.SeedData
{
    public class SeedSpeakerDeteil
    {
        public static void SeedSpeakerDetails(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SpeakerDetail>().HasData(
                new SpeakerDetail
                {
                    Id = 1,
                    UserId = "1",
                    ExperienceYear = 5,
                    Company = "Tech Innovators",
                    Position = "Senior Software Engineer",
                    SpeechImage = "john_doe_speech_image.jpg",
                    CreatedAt = DateTime.UtcNow
                },
                new SpeakerDetail
                {
                    Id = 2,
                    UserId = "2",
                    ExperienceYear = 8,
                    Company = "Health & Wellness Solutions",
                    Position = "Lead Nutritionist",
                    SpeechImage = "jane_smith_speech_image.jpg",
                    CreatedAt = DateTime.UtcNow
                },
                new SpeakerDetail
                {
                    Id = 3,
                    UserId = "3",
                    ExperienceYear = 10,
                    Company = "Artistic Creations",
                    Position = "Chief Creative Officer",
                    SpeechImage = "michael_johnson_speech_image.jpg",
                    CreatedAt = DateTime.UtcNow
                },
                new SpeakerDetail
                {
                    Id = 4,
                    UserId = "4",
                    ExperienceYear = 7,
                    Company = "GreenTech Solutions",
                    Position = "Environmental Scientist",
                    SpeechImage = "emily_anderson_speech_image.jpg",
                    CreatedAt = DateTime.UtcNow
                },
                new SpeakerDetail
                {
                    Id = 5,
                    UserId = "5",
                    ExperienceYear = 12,
                    Company = "Innovative Designs",
                    Position = "Lead Architect",
                    SpeechImage = "william_taylor_speech_image.jpg",
                    CreatedAt = DateTime.UtcNow
                }
            );
        }
    }
}

