using MDC.Server.Data.DbContexts;
using MDC.Server.Data.IRepositories;
using MDC.Server.Domain.Entities.References;

namespace MDC.Server.Data.Repositories;

public class RegionRepository : Repository<Region, int>, IRegionRepository
{
    public RegionRepository(MDCDbContext dbContext) : 
        base(dbContext)
    {
    }
}
