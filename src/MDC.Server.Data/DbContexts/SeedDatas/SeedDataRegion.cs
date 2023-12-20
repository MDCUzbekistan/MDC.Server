using Microsoft.EntityFrameworkCore;
using MDC.Server.Domain.Entities.References;

namespace MDC.Server.Data.DbContexts.SeedData.SeedDataRegions;

public static class SeedDataRegion
{
    public static void SeedDataRegions(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Region>()
            .HasData(
               new Region { Id = 1, Name = "North Region", Description = "Northern part of the country", CreatedAt = DateTime.UtcNow },
               new Region { Id = 2, Name = "South Region", Description = "Southern part of the country", CreatedAt = DateTime.UtcNow },
               new Region { Id = 3, Name = "East Region", Description = "Eastern part of the country", CreatedAt = DateTime.UtcNow },
               new Region { Id = 4, Name = "West Region", Description = "Western part of the country", CreatedAt = DateTime.UtcNow },
               new Region { Id = 5, Name = "Central Region", Description = "Central part of the country", CreatedAt = DateTime.UtcNow });
    }
}