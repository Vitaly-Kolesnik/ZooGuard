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
            using (unitOfWork)
            {
                await unitOfWork.StorageRepository.AddAsync(storage);

                await unitOfWork.SaveAsync();

                return true;
            }
        }
        public async Task<bool> DeleteAsync(int id)
        {
            using(unitOfWork)
            {
                await unitOfWork.StorageRepository.DeleteAsync(new Storage { Id = id });

                await unitOfWork.SaveAsync();

                return true;
            }
        }
        public async Task<bool> UpdateAsync(Storage storage)
        {
            using (unitOfWork)
            {
                await unitOfWork.StorageRepository.UpdateAsync(storage);

                await unitOfWork.SaveAsync();

                return true;
            }
        }
        public async Task<Storage> GetAsync(int id)
        {
            using (unitOfWork)
            {
                var entity = await unitOfWork.StorageRepository.GetAsync(id);

                return entity;
            }
        }
        public async Task<IList<Storage>> GetAllAsync()
        {
            using (unitOfWork)
            {
                var list = await unitOfWork.StorageRepository.ListAsync(new StorageSpecification());

                return list;
            }
        }
    }
}
