using MDC.Server.Data.DbContexts;
using MDC.Server.Data.IRepositories;
using MDC.Server.Domain.Entities.Events;

namespace MDC.Server.Data.Repositories;

public class EventRepository : Repository<Event,long> , IEventRepository
{
    public EventRepository(MDCDbContext dbContext) : base(dbContext)
    { }
}
