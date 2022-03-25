using System.Threading.Tasks;
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

        public async Task<bool> AddAsync(StorageViewModel storageViewModel)
        {
            return await storageService.AddAsync(ConvertToModel(storageViewModel));
        }

        public async Task<bool> EditAsync(StorageViewModel storageViewModel)
        {
            return await storageService.UpdateAsync(ConvertToModel(storageViewModel));
        }

        public async Task<StorageViewModel> GetByIdAsync(int id)
        {
            var storage = await storageService.GetAsync(id);
            return storage != null ? ConvertToViewModel(storage) : null;
        }

        public async Task<bool> DeleteAsync(int id) 
        {
            return await storageService.DeleteAsync(id);
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
