using MDC.Server.Data.DbContexts;
using MDC.Server.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using MDC.Server.Domain.Entities.Users;

namespace MDC.Server.Data.Repositories;
public class UserRepository : IUserRepository
{
    private readonly MDCDbContext _context;

    public UserRepository(MDCDbContext context)
    {
        _context = context;
    }

    public async Task<bool> DeleteAsync(string id)
    {
       var user = await _context.Users.FirstOrDefaultAsync(u => u.Id.Equals(id));

        _context.Users.Remove(user);

        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<User> InsertAsync(User user)
    {
        var entry = await _context.Users.AddAsync(user);

        await _context.SaveChangesAsync();

        return entry.Entity;
    }

    public  IQueryable<User> SelectAll()
    => _context.Users.AsQueryable();

    public async Task<User> SelectByIdAsync(string id)
    => await _context.Users.FirstOrDefaultAsync(u => u.Id.Equals(id));

    public async Task<User> UpdateAsync(User user)
    {
        var res =  _context.Users.Update(user);
        await _context.SaveChangesAsync();

        return res.Entity;
    }
}
