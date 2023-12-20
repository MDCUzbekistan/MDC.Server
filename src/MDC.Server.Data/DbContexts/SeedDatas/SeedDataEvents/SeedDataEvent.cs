using MDC.Server.Domain.Entities.Events;
using MDC.Server.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace MDC.Server.Data.DbContexts.SeedDatas.SeedDataEvents;

public static class SeedDataEvent
{
    public static void SeedDataEvents(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Event>().HasData(
            new Event
            {
                Id = 1,
                Title = "Tech Conference 2023",
                Description = "Explore the latest in technology and innovation.",
                Format = EventFormat.InPerson,
                Status = EventStatus.Review,
                LocationId = 1,
                LiveStreamUrl = "https://livestream.example.com/tech-conference",
                StartAt = DateTime.UtcNow.AddMonths(1),
                EndAt = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow
            },
            new Event
            {
                Id = 2,
                Title = "Fitness Expo",
                Description = "Join us for a fitness extravaganza.",
                Format = EventFormat.LiveStream,
                Status = EventStatus.Review,
                LocationId = 2,
                LiveStreamUrl = null,
                StartAt = DateTime.UtcNow,
                EndAt = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow

            },
            new Event
            {
                Id = 3,
                Title = "Book Club Meeting",
                Description = "Discuss your favorite books with fellow bookworms.",
                Format = EventFormat.Online,
                Status = EventStatus.Review,
                LocationId = 3,
                LiveStreamUrl = null,
                StartAt = DateTime.UtcNow,
                EndAt = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow

            },
            new Event
            {
                Id = 4,
                Title = "Art Exhibition",
                Description = "Discover and appreciate local artistic talent.",
                Format = EventFormat.InPerson,
                Status = EventStatus.Review,
                LocationId = 4,
                LiveStreamUrl = null,
                StartAt = DateTime.UtcNow,
                EndAt = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow

            },
            new Event
            {
                Id = 5,
                Title = "Community Cleanup",
                Description = "Join hands for a cleaner and greener community.",
                Format = EventFormat.InPerson,
                Status = EventStatus.Postponed,
                LocationId = 5,
                LiveStreamUrl = null,
                StartAt = DateTime.UtcNow,
                EndAt = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow,
            }
        );
    }
}
