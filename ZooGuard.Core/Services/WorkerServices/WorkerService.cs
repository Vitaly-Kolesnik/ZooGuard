using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities.WorkerEntities;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Interfaces.InterfaciesForWorkerServicies;

namespace ZooGuard.Core.Services.WorkerServices
{
    public class WorkerService : IWorkerService
    {
        private readonly IUnitOfWork unitOfWork;

        public WorkerService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> AddAsync(Worker worker)
        {
            using (unitOfWork)
            {
               await unitOfWork.WorkerRepository.AddAsync(worker);

                await unitOfWork.SaveAsync();

                return true;
            }
        }
        public async Task<bool> DeleteAsync(int id)
        {
            using(unitOfWork)
            {
                await unitOfWork.WorkerRepository.DeleteAsync(new Worker { Id = id });

                await unitOfWork.SaveAsync();

                return true;
            }
        }
        public async Task<bool> UpdateAsync(Worker worker)
        {
            using(unitOfWork)
            {
                await unitOfWork.WorkerRepository.UpdateAsync(worker);

                await unitOfWork.SaveAsync();

                return true;
            }
        }
        public async Task<IList<Worker>> GetAllAsync()
        {
            using (unitOfWork)
            {
                var list = await unitOfWork.WorkerRepository.ListAsync(new AllWorkerSpecification());

                return list;
            }
        }
        public async Task<Worker> GetAsync(int id)
        {
            using (unitOfWork)
            {
                return await unitOfWork.WorkerRepository.GetAsync(id);
            }
        }
    }
}
