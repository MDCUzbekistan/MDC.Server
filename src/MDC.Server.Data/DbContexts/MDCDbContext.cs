using Microsoft.EntityFrameworkCore;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Domain.Entities.Events;
using MDC.Server.Domain.Entities.References;
using MDC.Server.Domain.Entities.Communities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MDC.Server.Data.DbContexts.SeedDatas;
using MDC.Server.Data.DbContexts.SeedDatas.SeedDataEvents;
using MDC.Server.Data.DbContexts.SeedDatas.SeedDataUsers;
using MDC.Server.Data.DbContexts.SeedData.SeedDataCommunities;
using MDC.Server.Data.DbContexts.SeedData;
using MDC.Server.Data.DbContexts.SeedData.SeedDataRegions;

namespace MDC.Server.Data.DbContexts
{
    public class MDCDbContext : IdentityDbContext<User>
    {
        public MDCDbContext(DbContextOptions<MDCDbContext> options)
           : base(options) { }

        public DbSet<Event> Events { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<UserEvent> UserEvents { get; set; }
        public DbSet<EventRole> EventRoles { get; set; }
        public DbSet<Community> Communities { get; set; }
        public DbSet<UserDetail> UserDatails { get; set; }
        public DbSet<EventAsset> EventAssets { get; set; }
        public DbSet<EventSession> EventSessions { get; set; }
        public DbSet<UserLanguage> UserLanguages { get; set; }
        public DbSet<SpeakerDetail> SpeakerDetails { get; set; }
        public DbSet<CommunityRole> CommunityRoles { get; set; }
        public DbSet<UserCommunity> UserCommunities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Additional configuration for IdentityUserLogin<string>
            modelBuilder.Entity<IdentityUserLogin<string>>().HasKey(l => new { l.LoginProvider, l.ProviderKey });

            SeedData(modelBuilder);
        }
        private static void SeedData(ModelBuilder modelBuilder)
        {
            SeedDataRegion.SeedDataRegions(modelBuilder);
            SeedDataLanguage.SeedLanguages(modelBuilder);
            SeedDataLocation.SeedDataLocations(modelBuilder);

            SeedDataEvent.SeedDataEvents(modelBuilder);

            SeedEventRole.SeedEventRoles(modelBuilder);
            SeedEventAsset.SeedEventAssets(modelBuilder);
            SeedEventSession.SeedEventSessions(modelBuilder);

            SeedDataUser.SeedUsers(modelBuilder);

            SeedDataUserDetail.SeedUserDetails(modelBuilder);
            SeedSpeakerDeteil.SeedSpeakerDetails(modelBuilder);

            SeedCommunity.SeedDataCommunty(modelBuilder);
            SeedCommunityRoleData.SeedCommunityRoles(modelBuilder);

            SeedUserEventData.SeedUserEvents(modelBuilder);
            SeedUserLanguage.SeedUserLanguages(modelBuilder);
            SeedUserCommunityData.SeedUserCommunities(modelBuilder);
        }
        
    }
}
