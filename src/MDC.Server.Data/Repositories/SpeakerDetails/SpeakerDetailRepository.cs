using MDC.Server.Data.DbContexts;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Data.IRepositories.SpeakerDetails;

namespace MDC.Server.Data.Repositories.SpeakerDetails
{
    public class SpeakerDetailRepository : Repository<SpeakerDetail, long>, ISpeakerDetailRepository
    {
        public SpeakerDetailRepository(MDCDbContext dbContext)
                   : base(dbContext) { }

    }
}
