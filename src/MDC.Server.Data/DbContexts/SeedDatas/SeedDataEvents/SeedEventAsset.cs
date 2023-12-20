using Microsoft.EntityFrameworkCore;
using MDC.Server.Domain.Entities.Events;
using MDC.Server.Domain.Commons;
using System;

namespace MDC.Server.Data.DbContexts.SeedData
{
    public class SeedEventAsset
    {
        public static void SeedEventAssets(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventAsset>().HasData(
                new EventAsset
                {
                    Id = 1,
                    EventId = 1,
                    Image = "event-asset-image-1.jpg",
                    CreatedAt = DateTime.UtcNow
                },
                new EventAsset
                {
                    Id = 2,
                    EventId = 2,
                    Image = "event-asset-image-2.jpg",
                    CreatedAt = DateTime.UtcNow
                },
                new EventAsset
                {
                    Id = 3,
                    EventId = 3,
                    Image = "event-asset-image-3.jpg",
                    CreatedAt = DateTime.UtcNow
                },
                new EventAsset
                {
                    Id = 4,
                    EventId = 4,
                    Image = "event-asset-image-4.jpg",
                    CreatedAt = DateTime.UtcNow
                },
                new EventAsset
                {
                    Id = 5,
                    EventId = 5,
                    Image = "event-asset-image-5.jpg",
                    CreatedAt = DateTime.UtcNow
                }
            );
        }
    }
}
