using MDC.Server.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace MDC.Server.Data.DbContexts.SeedDatas.SeedDataUsers;

public static class SeedDataUser
{
    public static void SeedUsers(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id ="1",
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                PhoneNumber = "123456789",
                DateOfBirth = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow
            },
            new User
            {
                Id ="2",
                FirstName = "Jane",
                LastName = "Smith",
                Email = "jane.smith@example.com",
                PhoneNumber = "987654321",
                DateOfBirth = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow
            },
            new User
            {
                Id ="3",
                FirstName = "Michael",
                LastName = "Johnson",
                Email = "michael.johnson@example.com",
                PhoneNumber = "555555555",
                DateOfBirth = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow
            },
            new User
            {
                Id ="4",
                FirstName = "Emily",
                LastName = "Anderson",
                Email = "emily.anderson@example.com",
                PhoneNumber = "333333333",
                DateOfBirth = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow
            },
            new User
            {
                Id ="5",
                FirstName = "William",
                LastName = "Taylor",
                Email = "william.taylor@example.com",
                PhoneNumber = "777777777",
                DateOfBirth = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow
            }
        );
    }
}
