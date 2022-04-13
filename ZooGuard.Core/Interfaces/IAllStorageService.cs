using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities.BaseEntities;

namespace ZooGuard.Core.Interfaces
{
    public interface IAllStorageService <T> 
        where T : BaseStorageEntities, new()
    {
        Task<bool> AddAsync(T t);
        Task<T> GetAsync(int id);
        Task<bool> DeleteAsync(int id); 
        Task<IList<T>> ListAsync(string name);
        Task<bool> UpdateAsync(T t);
        Task<IList<T>> GetAllAsync();
    }
}
