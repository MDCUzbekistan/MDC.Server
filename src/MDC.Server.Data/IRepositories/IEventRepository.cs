using MDC.Server.Domain.Entities.Events;

namespace MDC.Server.Data.IRepositories;

public interface IEventRepository : IRepository<Event,long>
{
}
