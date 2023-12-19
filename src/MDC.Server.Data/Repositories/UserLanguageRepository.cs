using MDC.Server.Data.DbContexts;
using MDC.Server.Data.IRepositories;
using MDC.Server.Domain.Entities.Users;

namespace MDC.Server.Data.Repositories;

public class UserLanguageRepository : Repository<UserLanguage, long>, IUserLanguageRepository
{
    public UserLanguageRepository(MDCServerDbContext dbContext) : base(dbContext)
    {
    }
}
