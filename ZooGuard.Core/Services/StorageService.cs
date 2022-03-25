using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Specifications;

namespace ZooGuard.Core.Services
{
    public class StorageService : IStorageService
    {
        private readonly IRepository<Storage> storageRepository;

        public StorageService(IRepository<Storage> storageRepository)
        {
            this.storageRepository = storageRepository;
        }

        public async Task<bool> AddAsync(Storage storage)
        {
            return await storageRepository.AddAsync(storage);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await storageRepository.DeleteAsync(new Storage { Id = id });
        }

        public async Task<Storage> GetAsync(int id)
        {
            return await storageRepository.GetAsync(id);
        }

        public async Task<IList<Storage>> GetAllAsync()
        {
            return await storageRepository.ListAsync(new StorageSpecification());
        }

        public async Task<bool> UpdateAsync(Storage storage)
        {
            return await storageRepository.UpdateAsync(storage);
        }
    }
}
