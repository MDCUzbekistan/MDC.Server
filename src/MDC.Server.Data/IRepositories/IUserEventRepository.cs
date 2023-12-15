using MDC.Server.Domain.Entities.Auth;
using MDC.Server.Domain.Entities.Users;

namespace MDC.Server.Data.IRepositories;

public interface IUserEventRepository : IRepository<UserEvent,long>
{
}
