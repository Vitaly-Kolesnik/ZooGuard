using System.Threading.Tasks;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Interfaces
{
    public interface IStatusViewModelService
    {
        Task<bool> AddAsync(StatusViewModel statusViewModel);
        Task<StatusViewModel> GetByIdAsync(int value);
        Task<bool> DeleteAsync(int id);
    }
}
