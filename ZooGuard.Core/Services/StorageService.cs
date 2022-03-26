using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Specifications;

namespace ZooGuard.Core.Services
{
    public class StorageService : IStorageService
    {
        private readonly IUnitOfWork unitOfWork;

        public StorageService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> AddAsync(Storage storage)
        {
            await unitOfWork.StorageRepository.AddAsync(storage);

            await unitOfWork.SaveAsync();

            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            await unitOfWork.StorageRepository.DeleteAsync(new Storage { Id = id });

            await unitOfWork.SaveAsync();

            return true;
        }

        public async Task<Storage> GetAsync(int id)
        {   
            return await unitOfWork.StorageRepository.GetAsync(id);
        }

        public async Task<IList<Storage>> GetAllAsync()
        {
            return await unitOfWork.StorageRepository.ListAsync(new StorageSpecification());
        }

        public async Task<bool> UpdateAsync(Storage storage)
        {
            await  unitOfWork.StorageRepository.UpdateAsync(storage);

            await unitOfWork.SaveAsync();

            return true;
        }
    }
}
