using MDC.Server.Domain.Entities.References;
using Microsoft.EntityFrameworkCore;

namespace MDC.Server.Data.DbContexts.SeedDatas;

public static class SeedDataLocation
{
    public static void SeedDataLocations(ModelBuilder builder)
    {
        builder.Entity<Location>()
            .HasData(

                    new Location { Id = 1, Longitude = 123456, Latitude = 789012, Address = "123 Main St", CreatedAt = DateTime.UtcNow },
                    new Location { Id = 2, Longitude = 654321, Latitude = 210987, Address = "456 Oak Ave", CreatedAt = DateTime.UtcNow },
                    new Location { Id = 3, Longitude = 111222, Latitude = 333444, Address = "789 Elm St", CreatedAt = DateTime.UtcNow },
                    new Location { Id = 4, Longitude = 555666, Latitude = 777888, Address = "987 Pine Ave", CreatedAt = DateTime.UtcNow },
                    new Location { Id = 5, Longitude = 999000, Latitude = 123789, Address = "654 Birch Ln", CreatedAt = DateTime.UtcNow }
            );
    }
}
