using MDC.Server.Data.DbContexts;
using MDC.Server.Data.IRepositories;
using MDC.Server.Domain.Entities.Events;

namespace MDC.Server.Data.Repositories;

public class EventRoleRepository : Repository<EventRole, short>, IEventRoleRepository
{
    public EventRoleRepository(MDCDbContext dbContext) : base(dbContext)
    { }
}
