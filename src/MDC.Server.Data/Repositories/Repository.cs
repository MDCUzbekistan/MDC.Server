using MDC.Server.Data.DbContexts;
using MDC.Server.Data.IRepositories;
using MDC.Server.Domain.Commons;
using Microsoft.EntityFrameworkCore;

namespace MDC.Server.Data.Repositories;

public class Repository<TEntity, TKey> : IRepository<TEntity,TKey> where TEntity : Auditable<TKey>
{
    protected readonly MDCDbContext _dbContext;
    protected readonly DbSet<TEntity> _dbSet;

    public Repository(MDCDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<TEntity>();
    }


    public async Task<TEntity> InsertAsync(TEntity entity)
    {
        var entry = await _dbSet.AddAsync(entity);

        await _dbContext.SaveChangesAsync();

        return entry.Entity;
    }


    public async Task<bool> DeleteAsync(TKey id)
    {
        var entity = await _dbSet.FirstOrDefaultAsync(e => e.Id.Equals(id));
        _dbSet.Remove(entity);

        return await _dbContext.SaveChangesAsync() > 0;
    }


    public IQueryable<TEntity> SelectAll()
        => _dbSet;

    public async Task<TEntity> SelectByIdAsync(TKey id)
        => await _dbSet.FirstOrDefaultAsync(e => e.Id.Equals(id));

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        var entry = _dbContext.Update(entity);
        await _dbContext.SaveChangesAsync();

        return entry.Entity;
    }
}
