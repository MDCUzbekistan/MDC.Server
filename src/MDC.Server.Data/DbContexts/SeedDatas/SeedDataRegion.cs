using Microsoft.EntityFrameworkCore;
using MDC.Server.Domain.Entities.References;
using MDC.Server.Domain.Commons;
using System;

namespace MDC.Server.Data.DbContexts.SeedData
{
    public static class SeedDataRegion
    {
        public static void SeedRegions(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Region>().HasData(
                new Region
                {
                    Id = 1,
                    Country = "Country1",
                    City = "City1",
                    CreatedAt = DateTime.UtcNow
                },
                new Region
                {
                    Id = 2,
                    Country = "Country2",
                    City = "City2",
                    CreatedAt = DateTime.UtcNow
                },
                new Region
                {
                    Id = 3,
                    Country = "Country3",
                    City = "City3",
                    CreatedAt = DateTime.UtcNow
                },
                new Region
                {
                    Id = 4,
                    Country = "Country4",
                    City = "City4",
                    CreatedAt = DateTime.UtcNow
                },
                new Region
                {
                    Id = 5,
                    Country = "Country5",
                    City = "City5",
                    CreatedAt = DateTime.UtcNow
                }
            );
        }
    }
}
