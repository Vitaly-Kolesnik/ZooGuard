using ZooGuard.Core.Entities;
using ZooGuard.Core.Interfaces;
using ZooGuard.Web.Interfaces;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Services
{
    public class StorageViewModelService : IStorageViewModelService
    {
        private readonly IStorageService storageService;

        public StorageViewModelService(IStorageService storageService)
        {
            this.storageService = storageService;
        }

        public int Add(StorageViewModel storageViewModel)
        {
            return storageService.Add(ConvertToModel(storageViewModel));
        }

        public void Edit(StorageViewModel storageViewModel)
        {
            storageService.Update(ConvertToModel(storageViewModel));
        }

        public StorageViewModel GetById(int id)
        {
            var storage = storageService.Get(id);
            return storage != null ? ConvertToViewModel(storage) : null;
        }

        public StorageViewModel GetEmpty()
        {
            throw new System.NotImplementedException();
        }

        private StorageViewModel ConvertToViewModel(Storage storage) //для формировани модели, для возврата
        {
            return new StorageViewModel
            {
                Id = storage.Id,
                Name = storage.Name,
                ActualAddress = storage.ActualAddress,
                Characteristic = storage.Characteristic,
            };
        }

        private Storage ConvertToModel(StorageViewModel storageViewModel)
        {
            return new Storage
            {
                Id = storageViewModel.Id.HasValue ? storageViewModel.Id.Value : 0,
                Name = storageViewModel.Name,
                ActualAddress = storageViewModel.ActualAddress,
                Characteristic= storageViewModel.Characteristic,
            };
        }
    }
}
