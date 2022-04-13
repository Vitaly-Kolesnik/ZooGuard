using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities.WorkerEntities;

namespace ZooGuard.Core.Interfaces.InterfaciesForWorkerServicies
{
    public interface IWorkerService
    {
        Task<bool> AddAsync(Worker worker);
        Task<bool> DeleteAsync(int id);
        Task<bool> UpdateAsync(Worker worker);
        Task<Worker> GetAsync(int id);
        Task<IList<Worker>> GetAllAsync();
    }
}
