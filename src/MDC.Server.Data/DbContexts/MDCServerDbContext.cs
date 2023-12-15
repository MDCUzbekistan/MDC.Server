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
        public DbSet<Domain.Entities.Communities.UserCommunity> UserCommunities { get; set; }
    }
}
