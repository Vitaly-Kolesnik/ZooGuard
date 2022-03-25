using System.Threading.Tasks;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Interfaces
{
    public interface IStorageViewModelService
    {
        Task<bool> AddAsync(StorageViewModel storageViewModel);
        Task<StorageViewModel> GetByIdAsync(int id);
        Task<bool> EditAsync(StorageViewModel storageViewModel);
        Task<bool> DeleteAsync(int id);
    }
}
