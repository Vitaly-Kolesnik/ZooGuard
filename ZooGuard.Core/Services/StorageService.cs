using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public int Add(Storage storage)
        {
            storageRepository.Add(storage);
            return storage.Id;
        }

        public void Delete(int id)
        {
            storageRepository.Delete(new Storage { Id = id });
        }

        public Storage Get(int id)
        {
            return storageRepository.Get(id);
        }

        public IList<Storage> GetAll()
        {
            return storageRepository.List(new StorageSpecification());
        }

        public int Update(Storage storage)
        {
            storageRepository.Update(storage);
            return storage.Id;
        }
    }
}
