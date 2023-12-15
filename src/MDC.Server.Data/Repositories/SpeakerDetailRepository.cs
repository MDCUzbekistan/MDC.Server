using MDC.Server.Data.DbContexts;
using MDC.Server.Domain.Entities.Users;

namespace MDC.Server.Data.Repositories
{
    public class SpeakerDetailRepository : Repository<SpeakerDetail, long>
    {
        public SpeakerDetailRepository(MDCServerDbContext dbContext) 
               : base(dbContext) { }
    }
}
