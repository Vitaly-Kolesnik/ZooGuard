using ZooGuard.Web.Models;

namespace ZooGuard.Web.Interfaces
{
    public interface IStorageViewModelService
    {
        int Add(StorageViewModel storageViewModel);
        StorageViewModel GetById(int id);
        void Edit(StorageViewModel storageViewModel);
        StorageViewModel GetEmpty();
    }
}
