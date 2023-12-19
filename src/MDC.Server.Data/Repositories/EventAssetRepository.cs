using MDC.Server.Data.DbContexts;
using MDC.Server.Data.IRepositories;
using MDC.Server.Domain.Entities.Events;

namespace MDC.Server.Data.Repositories;

public class EventAssetRepository : Repository<EventAsset, long>, IEventAssetReposiytory
{
    public EventAssetRepository(MDCDbContext dbContext) : base(dbContext)
    {
    }
}
