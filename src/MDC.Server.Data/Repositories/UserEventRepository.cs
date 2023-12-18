using MDC.Server.Data.DbContexts;
using MDC.Server.Data.IRepositories;
using MDC.Server.Domain.Entities.Users;

namespace MDC.Server.Data.Repositories;

public class UserEventRepository : Repository<UserEvent, long>, IUserEventRepository
{
    public UserEventRepository(MDCDbContext dbContext) : base(dbContext)
    { }
}
