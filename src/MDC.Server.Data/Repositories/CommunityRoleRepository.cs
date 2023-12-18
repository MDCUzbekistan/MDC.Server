using MDC.Server.Data.DbContexts;
using MDC.Server.Data.IRepositories;
using MDC.Server.Domain.Entities.Communities;

namespace MDC.Server.Data.Repositories;

public class CommunityRoleRepository : Repository<CommunityRole, short>, ICommunityRoleRepository
{
    public CommunityRoleRepository(MDCDbContext dbContext) : base(dbContext)
    { }
}
