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
        bool Find(ISpecification<TEntity> specification);
        Task<TEntity> GetAsync(int id);
        Task<TEntity> GetAsync(ISpecification<TEntity> specification);
        Task<IList<TEntity>> ListAsync();
        Task<IList<TEntity>> ListAsync(ISpecification<TEntity> specification);
    }
}
