using MDC.Server.Data.DbContexts;
using MDC.Server.Data.IRepositories;
using MDC.Server.Domain.Entities.Communities;

namespace MDC.Server.Data.Repositories
{
    public class CommunityRepository : Repository<Community,long>, ICommunityRepository
    {
        public CommunityRepository(MDCDbContext dbContext) : base(dbContext)
        {
        }
    }
}
