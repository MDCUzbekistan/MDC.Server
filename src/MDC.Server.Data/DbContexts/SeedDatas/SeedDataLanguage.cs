using Microsoft.EntityFrameworkCore;
using MDC.Server.Domain.Entities.References;

namespace MDC.Server.Data.DbContexts.SeedData
{
    public class SeedDataLanguage
    {
        public static void SeedLanguages(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>()
                .HasData(
                new Language { Id = 1, Name = "English", CreatedAt = DateTime.UtcNow },
                new Language { Id = 2, Name = "Uzbek", CreatedAt = DateTime.UtcNow },
                new Language { Id = 3, Name = "French", CreatedAt = DateTime.UtcNow },
                new Language { Id = 4, Name = "German", CreatedAt = DateTime.UtcNow },
                new Language { Id = 5, Name = "Russian", CreatedAt = DateTime.UtcNow }
            );
        }
    }
}