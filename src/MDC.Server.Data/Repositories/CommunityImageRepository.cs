using MDC.Server.Data.DbContexts;
using MDC.Server.Data.IRepositories;
using MDC.Server.Domain.Entities.Communities;

namespace MDC.Server.Data.Repositories;

public class CommunityImageRepository : Repository<CommunityImage, long>, ICommunityImageRepository
{
    public CommunityImageRepository(MDCServerDbContext dbContext) : base(dbContext)
    {
    }
}
