using MDC.Server.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;

namespace MDC.Server.Data.DbContexts.SeedDatas.SeedDataUsers
{
    public static class SeedDataUserDetail
    {
        public static void SeedUserDetails(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserDetail>().HasData(
                new UserDetail
                {
                    Id = 1,
                    UserId = "1",
                    Image = "john-doe-image-url",
                    Resume = "John Doe's resume details"
                },
                new UserDetail
                {
                    Id = 2,
                    UserId = "2",
                    Image = "jane-smith-image-url",
                    Resume = "Jane Smith's resume details"
                },
                new UserDetail
                {
                    Id = 3,
                    UserId = "3",
                    Image = "michael-johnson-image-url",
                    Resume = "Michael Johnson's resume details"
                },
                new UserDetail
                {
                    Id = 4,
                    UserId = "4",
                    Image = "emily-anderson-image-url",
                    Resume = "Emily Anderson's resume details"
                },
                new UserDetail
                {
                    Id = 5,
                    UserId = "5",
                    Image = "william-taylor-image-url",
                    Resume = "William Taylor's resume details"
                }
            );
        }
    }
}
