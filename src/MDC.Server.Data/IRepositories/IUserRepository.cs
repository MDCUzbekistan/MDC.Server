using MDC.Server.Domain.Entities.Users;

namespace MDC.Server.Data.IRepositories;
public interface IUserRepository:IRepository<User, long>
{
}
