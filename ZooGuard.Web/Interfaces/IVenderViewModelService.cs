using System.Threading.Tasks;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Interfaces
{
    public interface IVenderViewModelService
    {
        Task<bool> AddAsync(VenderViewModel venderViewModel);
        Task<VenderViewModel> GetByIdAsync(int id);
        Task<bool> EditAsync(VenderViewModel vender);
        Task<bool> DeleteAsync(int id);
    }
}
