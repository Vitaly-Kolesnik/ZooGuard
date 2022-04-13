using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities.WorkerEntities;

namespace ZooGuard.Core.Interfaces.InterfaciesForWorkerServicies
{
    public interface ISpecialityWorkerService
    {
        Task<bool> AddAsync(SpecialityWorker specialityWorker);
        Task<bool> DeleteAsync(int id);
        Task<bool> UpdateAsync(SpecialityWorker specialityWorker);
        Task<SpecialityWorker> GetAsync(int id);
        Task<IList<SpecialityWorker>> GetAllAsync();
    }
}
