using Microsoft.EntityFrameworkCore;
using MDC.Server.Domain.Entities.Events;

namespace MDC.Server.Data.DbContexts.SeedData
{
    public static class SeedEventRole
    {
        public static void SeedEventRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventRole>()
                .HasData(
                new EventRole { Id = 1, Name = "Organizer", Description = "Responsible for planning and managing the event.", CreatedAt = DateTime.UtcNow },
                new EventRole { Id = 2, Name = "Speaker", Description = "Presenting talks or sessions during the event.", CreatedAt = DateTime.UtcNow },
                new EventRole { Id = 3, Name = "Participant", Description = "Attending the event without a specific role.", CreatedAt = DateTime.UtcNow },
                new EventRole { Id = 4, Name = "Volunteer", Description = "Assisting with various tasks during the event.", CreatedAt = DateTime.UtcNow },
                new EventRole { Id = 5, Name = "Sponsor", Description = "Supporting the event financially or with resources.", CreatedAt = DateTime.UtcNow }
            );
        }
    }
}