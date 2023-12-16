using Microsoft.EntityFrameworkCore;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Domain.Entities.Events;
using MDC.Server.Domain.Entities.References;
using MDC.Server.Domain.Entities.Communities;

namespace MDC.Server.Data.DbContexts
{
    public class MDCServerDbContext : DbContext
    {
        public MDCServerDbContext(DbContextOptions<MDCServerDbContext> options)
           : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<UserEvent> UserEvents { get; set; }
        public DbSet<EventRole> EventRoles { get; set; }
        public DbSet<Community> Communities { get; set; }
        public DbSet<UserDetail> UserDatails { get; set; }
        public DbSet<EventSession> EventSessions { get; set; }
        public DbSet<UserLanguage> UserLanguages { get; set; }
        public DbSet<SpeakerDetail> SpeakerDetails { get; set; }
        public DbSet<CommunityRole> CommunityRoles { get; set; }
        public DbSet<UserCommunity> UserCommunities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasOne(u => u.UserDetail)
            .WithOne(ud => ud.User)
            .HasForeignKey<UserDetail>(ud => ud.UserId)
            .OnDelete(DeleteBehavior.Cascade);


            // User - UserLanguage
            modelBuilder.Entity<UserLanguage>()
                .HasOne(ul => ul.User)
                .WithMany(l => l.Languages)
                .HasForeignKey(ul => ul.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // User - UserEvent
            modelBuilder.Entity<UserEvent>()
                .HasOne(ue => ue.User)
                .WithMany(u => u.Events)
                .HasForeignKey(ue => ue.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // User - UserCommunity
            modelBuilder.Entity<UserCommunity>()
                .HasOne(uc => uc.User)
                .WithMany(u => u.UserCommunities)
                .HasForeignKey(uc => uc.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // User - Detail
            modelBuilder.Entity<User>()
                .HasOne(u => u.UserDetail)
                .WithOne(ud => ud.User)
                .HasForeignKey<UserDetail>(ud => ud.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Event
            modelBuilder.Entity<Event>()
                .HasMany(e => e.Sessions)
                .WithOne(es => es.Event)
                .HasForeignKey(es => es.EventId)
                .OnDelete(DeleteBehavior.Cascade);

            //Comunity and UserComunity
            modelBuilder.Entity<UserCommunity>();
                
        }
    }
}
