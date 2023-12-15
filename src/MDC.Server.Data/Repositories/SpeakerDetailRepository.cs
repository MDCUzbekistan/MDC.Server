using MDC.Server.Data.DbContexts;
using MDC.Server.Data.IRepositories;
using MDC.Server.Domain.Entities.Users;

namespace MDC.Server.Data.Repositories
{
    public class SpeakerDetailRepository : Repository<SpeakerDetail, long>, ISpeakerDetailRepositor
    {
        public SpeakerDetailRepository(MDCServerDbContext dbContext) 
               : base(dbContext) { }
    }
}
