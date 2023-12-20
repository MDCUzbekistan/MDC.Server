using Microsoft.EntityFrameworkCore;
using MDC.Server.Domain.Entities.Communities;

namespace MDC.Server.Data.DbContexts.SeedData
{
    public static class SeedCommunityRoleData
    {
        public static void SeedCommunityRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CommunityRole>()
                .HasData(
                new CommunityRole { Id = 1, Name = "Administrator", Description = "Community administrator role.", CreatedAt = DateTime.UtcNow },
                new CommunityRole { Id = 2, Name = "Member", Description = "Standard community member role.", CreatedAt = DateTime.UtcNow },
                new CommunityRole { Id = 3, Name = "Moderator", Description = "Community moderator role.", CreatedAt = DateTime.UtcNow },
                new CommunityRole { Id = 4, Name = "Guest", Description = "Guest role for limited access.", CreatedAt = DateTime.UtcNow },
                new CommunityRole { Id = 5, Name = "Editor", Description = "Community content editor role.", CreatedAt = DateTime.UtcNow }
            );
        }
    }
}