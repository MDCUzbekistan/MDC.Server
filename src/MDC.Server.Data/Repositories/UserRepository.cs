using MDC.Server.Data.DbContexts;
using MDC.Server.Data.IRepositories;
using MDC.Server.Domain.Entities.Users;

namespace MDC.Server.Data.Repositories;
public class UserRepository : Repository<User, long>, IUserRepository
{
    public UserRepository(MDCServerDbContext dbContext) : base(dbContext)
    {
    }
}
