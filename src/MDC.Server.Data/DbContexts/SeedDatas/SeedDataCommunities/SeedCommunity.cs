
using Microsoft.EntityFrameworkCore;
using MDC.Server.Domain.Entities.Communities;

namespace MDC.Server.Data.DbContexts.SeedData.SeedDataCommunities;

public static class SeedCommunity
{
    public static void SeedDataCommunty(ModelBuilder builder)
    {
        builder.Entity<Community>()
            .HasData(
                new Community { Id = 1, Title = "Tech Enthusiasts", Description = "A community for technology enthusiasts.", Bio = "Explore the latest in tech trends.", Banner = "tech_banner.jpg", Logo = "tech_logo.png", ParentId = null, CreatedAt = DateTime.UtcNow },
                new Community { Id = 2, Title = "Outdoor Adventures", Description = "For those who love outdoor activities.", Bio = "Connect with nature and fellow adventurers.", Banner = "outdoor_banner.jpg", Logo = "outdoor_logo.png", ParentId = null, CreatedAt = DateTime.UtcNow },
                new Community { Id = 3, Title = "Book Lovers Club", Description = "A community for bookworms and literature enthusiasts.", Bio = "Discuss your favorite books and discover new ones.", Banner = "books_banner.jpg", Logo = "books_logo.png", ParentId = null, CreatedAt = DateTime.UtcNow },
                new Community { Id = 4, Title = "Fitness Fanatics", Description = "For fitness enthusiasts and health-conscious individuals.", Bio = "Share workout tips and stay motivated.", Banner = "fitness_banner.jpg", Logo = "fitness_logo.png", ParentId = null, CreatedAt = DateTime.UtcNow },
                new Community { Id = 5, Title = "Art and Creativity", Description = "Explore and share your artistic side.", Bio = "Connect with fellow artists and creators.", Banner = "art_banner.jpg", Logo = "art_logo.png", ParentId = null, CreatedAt = DateTime.UtcNow }
                );
    }
}