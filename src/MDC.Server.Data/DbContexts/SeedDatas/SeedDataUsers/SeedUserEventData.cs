using Microsoft.EntityFrameworkCore;
using MDC.Server.Domain.Entities.Users;

namespace MDC.Server.Data.DbContexts.SeedData
{
    public class SeedUserEventData
    {
        public static void SeedUserEvents(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEvent>()
                .HasData(
                new UserEvent { Id = 1, UserId = "1", EventId = 1, RoleId = 1, CreatedAt = DateTime.UtcNow },
                new UserEvent { Id = 2, UserId = "2", EventId = 2, RoleId = 2, CreatedAt = DateTime.UtcNow },
                new UserEvent { Id = 3, UserId = "3", EventId = 3, RoleId = 1, CreatedAt = DateTime.UtcNow },
                new UserEvent { Id = 4, UserId = "4", EventId = 4, RoleId = 3, CreatedAt = DateTime.UtcNow },
                new UserEvent { Id = 5, UserId = "5", EventId = 5, RoleId = 2, CreatedAt = DateTime.UtcNow }
            );
        }
    }
}