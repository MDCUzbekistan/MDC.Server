using MDC.Server.Data.DbContexts;
using MDC.Server.Data.IRepositories;
using MDC.Server.Domain.Entities.Users;

namespace MDC.Server.Data.Repositories;

public class UserDetailRepository : Repository<UserDetail, long>, IUserDetailRepository
{
    public UserDetailRepository(MDCServerDbContext dbContext) : base(dbContext)
    {
    }
}
