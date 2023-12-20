
using MDC.Server.Domain.Entities.Users;

namespace MDC.Server.Data.IRepositories;
public interface IUserRepository
{
    IQueryable<User> SelectAll();
    Task<User>  InsertAsync(User user);
    Task<bool> DeleteAsync(string id);
    Task<User> UpdateAsync(User user);
    Task<User> SelectByIdAsync(string id);
}
