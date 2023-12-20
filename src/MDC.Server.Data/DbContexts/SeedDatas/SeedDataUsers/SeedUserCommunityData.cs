using Microsoft.EntityFrameworkCore;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Domain.Entities.Communities;

namespace MDC.Server.Data.DbContexts.SeedData
{
    public class SeedUserCommunityData
    {
        public static void SeedUserCommunities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserCommunity>().HasData(
                new UserCommunity { Id = 1, UserId = "1", CommunityId = 1, RoleId = 1, CreatedAt = DateTime.UtcNow },
                new UserCommunity { Id = 2, UserId = "2", CommunityId = 2, RoleId = 2, CreatedAt = DateTime.UtcNow },
                new UserCommunity { Id = 3, UserId = "3", CommunityId = 3, RoleId = 1, CreatedAt = DateTime.UtcNow },
                new UserCommunity { Id = 4, UserId = "4", CommunityId = 4, RoleId = 3, CreatedAt = DateTime.UtcNow },
                new UserCommunity { Id = 5, UserId = "5", CommunityId = 5, RoleId = 2, CreatedAt = DateTime.UtcNow }
            );
        }
    }
}