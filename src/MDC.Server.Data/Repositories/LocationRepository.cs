using MDC.Server.Data.DbContexts;
using MDC.Server.Data.IRepositories;
using MDC.Server.Domain.Entities.References;

namespace MDC.Server.Data.Repositories;

public class LocationRepository : Repository<Location, long>, ILocationRepository
{
    public LocationRepository(MDCServerDbContext dbContext) : base(dbContext)
    { }
}
