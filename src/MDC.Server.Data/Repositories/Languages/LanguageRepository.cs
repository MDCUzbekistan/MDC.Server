using MDC.Server.Data.DbContexts;
using MDC.Server.Data.IRepositories.Languages;
using MDC.Server.Domain.Entities.References;

namespace MDC.Server.Data.Repositories.Languages;

public class LanguageRepository : Repository<Language, short>, ILanguageRepository
{
    public LanguageRepository(MDCServerDbContext dbContext) : base(dbContext)
    {
    }
}