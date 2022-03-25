using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities;

namespace ZooGuard.Core.Interfaces
{
    public interface IVenderService
    {
        Task<bool> AddAsync(Vender vender);
        Task<Vender> GetAsync(int id);
        Task<IList<Vender>> ListAsync(string name);
        Task<IList<Vender>> GetAllAsync();
        Task<bool> DeleteAsync(int id);
        Task<bool> UpdateAsync(Vender position);
    }
}
