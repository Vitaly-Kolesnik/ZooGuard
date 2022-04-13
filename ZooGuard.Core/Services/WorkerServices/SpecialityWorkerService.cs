using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities.WorkerEntities;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Interfaces.InterfaciesForWorkerServicies;

namespace ZooGuard.Core.Services.WorkerServices
{
    public class SpecialityWorkerService : ISpecialityWorkerService
    {
        private readonly IUnitOfWork unitOfWork;
        public SpecialityWorkerService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> AddAsync(SpecialityWorker specialityWorker)
        {
            using(unitOfWork)
            {
                await unitOfWork.SpecialityWorkerRepository.AddAsync(specialityWorker);

                await unitOfWork.SaveAsync();

                return true;
            }
        }
        public async Task<bool> DeleteAsync(int id)
        {
            using (unitOfWork)
            {
                await unitOfWork.SpecialityWorkerRepository.DeleteAsync(new SpecialityWorker { Id = id });

                await unitOfWork.SaveAsync();

                return true;
            }
        }
        public async Task<IList<SpecialityWorker>> GetAllAsync()
        {
            using (unitOfWork)
            {
                return await unitOfWork.SpecialityWorkerRepository.ListAsync();
            }
        }
        public async Task<SpecialityWorker> GetAsync(int id)
        {
            using (unitOfWork)
            {
                return await unitOfWork.SpecialityWorkerRepository.GetAsync(id);
            }
        }
        public async Task<bool> UpdateAsync(SpecialityWorker specialityWorker)
        {
            using (unitOfWork)
            {
                await unitOfWork.SpecialityWorkerRepository.UpdateAsync(specialityWorker);

                await unitOfWork.SaveAsync();

                return true;
            }
        }
    }
}
