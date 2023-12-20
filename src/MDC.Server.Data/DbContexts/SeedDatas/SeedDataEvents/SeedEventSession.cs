using Microsoft.EntityFrameworkCore;
using MDC.Server.Domain.Entities.Events;
using MDC.Server.Domain.Entities.Users;
using System;

namespace MDC.Server.Data.DbContexts.SeedData
{
    public static class SeedEventSession
    {
        public static void SeedEventSessions(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventSession>().HasData(
                new EventSession
                {
                    Id = 1,
                    EventId = 1,
                    Name = "Keynote Address",
                    Description = "An inspiring keynote to kick off the event.",
                    StartAt = DateTime.UtcNow.AddMonths(1).AddDays(1),
                    EndAt = DateTime.UtcNow.AddMonths(1).AddDays(1).AddHours(1),
                    SpeakerId = "1", // Convert to string
                    CreatedAt = DateTime.UtcNow
                },
                new EventSession
                {
                    Id = 2,
                    EventId = 2,
                    Name = "Panel Discussion",
                    Description = "A panel discussion on the future of technology.",
                    StartAt = DateTime.UtcNow.AddMonths(2).AddDays(2),
                    EndAt = DateTime.UtcNow.AddMonths(2).AddDays(2).AddHours(1),
                    SpeakerId = "2", // Convert to string
                    CreatedAt = DateTime.UtcNow
                },
                new EventSession
                {
                    Id = 3,
                    EventId = 3,
                    Name = "Book Club Discussion",
                    Description = "A discussion on the latest book club selection.",
                    StartAt = DateTime.UtcNow.AddMonths(3).AddDays(3),
                    EndAt = DateTime.UtcNow.AddMonths(3).AddDays(3).AddHours(1),
                    SpeakerId = "3", // Convert to string
                    CreatedAt = DateTime.UtcNow
                },
                new EventSession
                {
                    Id = 4,
                    EventId = 4,
                    Name = "Art Workshop",
                    Description = "Hands-on workshop for aspiring artists.",
                    StartAt = DateTime.UtcNow.AddMonths(4).AddDays(4),
                    EndAt = DateTime.UtcNow.AddMonths(4).AddDays(4).AddHours(2),
                    SpeakerId = "4", // Convert to string
                    CreatedAt = DateTime.UtcNow
                },
                new EventSession
                {
                    Id = 5,
                    EventId = 5,
                    Name = "Community Planning Session",
                    Description = "Collaborative session to plan community initiatives.",
                    StartAt = DateTime.UtcNow.AddMonths(5).AddDays(5),
                    EndAt = DateTime.UtcNow.AddMonths(5).AddDays(5).AddHours(1),
                    SpeakerId = "5", // Convert to string
                    CreatedAt = DateTime.UtcNow
                }
            );
        }
    }
}
