using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities;

namespace ZooGuard.Core.Interfaces
{
    public interface IBrokenService
    {
        Task<bool> AddAsync(Broken broken);
        Task<bool> DeleteAsync(int id);
        Task<bool> UpdateAsync(Broken broken);
        Task<Broken> GetAsync(int id);
        Task<IList<Broken>> ListAsync(string name);
        Task<IList<Broken>> GetAllAsync();
    }
}
