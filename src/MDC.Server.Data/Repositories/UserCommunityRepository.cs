using MDC.Server.Data.DbContexts;
using MDC.Server.Data.IRepositories;
using MDC.Server.Domain.Entities.Communities;

namespace MDC.Server.Data.Repositories;

public class UserCommunityRepository : Repository<UserCommunity, long>, IUserCommunityRepository
{
    public UserCommunityRepository(MDCDbContext dbContext) : base(dbContext)
    {

    }
}
