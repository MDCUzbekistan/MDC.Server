using MDC.Server.Domain.Commons;

namespace MDC.Server.Data.IRepositories;

public interface IRepository<TEntity> where TEntity : Auditable<TEntity>
{
    Task<bool> DeleteAsync(TEntity id);
    IQueryable<TEntity> SelectAll();
    Task<TEntity> SelectByIdAsync(TEntity id);
    Task<TEntity> InsertAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity);
}
