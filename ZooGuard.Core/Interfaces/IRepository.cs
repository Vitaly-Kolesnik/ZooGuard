using System.Collections.Generic;
using System.Threading.Tasks;

namespace ZooGuard.Core.Interfaces
{
    public interface IRepository<TEntity> 
        where TEntity : class
    {
        Task<bool> AddAsync(TEntity entity);
        Task<bool> UpdateAsync(TEntity entity);
        Task<bool> DeleteAsync(TEntity entity);
        Task<TEntity> GetAsync(int id);
        Task<TEntity> GetAsync(Specifications<TEntity> specification);
        Task<IList<TEntity>> ListAsync();
        Task<IList<TEntity>> ListAsync(Specifications<TEntity> specification);
    }
}
