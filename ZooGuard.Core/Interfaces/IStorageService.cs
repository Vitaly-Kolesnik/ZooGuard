using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities;

namespace ZooGuard.Core.Interfaces
{
    public interface IStorageService
    {
        Task<bool> AddAsync(Storage storage);
        Task<bool> DeleteAsync(int id);
        Task<Storage> GetAsync(int id);
        Task<IList<Storage>> GetAllAsync();
        Task<bool> UpdateAsync(Storage storage);
    }
}
