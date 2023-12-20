using Microsoft.EntityFrameworkCore;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Domain.Entities.References;

namespace MDC.Server.Data.DbContexts.SeedData
{
    public static class SeedUserLanguage
    {
        public static void SeedUserLanguages(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserLanguage>()
                .HasData(
                new UserLanguage { Id = 1, UserId = "1", LanguageId = 1, CreatedAt = DateTime.UtcNow },
                new UserLanguage { Id = 2, UserId = "2", LanguageId = 2, CreatedAt = DateTime.UtcNow },
                new UserLanguage { Id = 3, UserId = "3", LanguageId = 3, CreatedAt = DateTime.UtcNow },
                new UserLanguage { Id = 4, UserId = "4", LanguageId = 4, CreatedAt = DateTime.UtcNow },
                new UserLanguage { Id = 5, UserId = "5", LanguageId = 5, CreatedAt = DateTime.UtcNow }
            );
        }
    }
}