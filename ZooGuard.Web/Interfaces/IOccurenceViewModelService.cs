using System.Threading.Tasks;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Interfaces
{
    public interface IOccurenceViewModelService
    {
        Task<bool> AddAsync(OccurenceViewModel occurenceViewModel);
        Task<bool> DeleteByIdAsync(int id);
        Task<OccurenceViewModel> GetByIdAsync(int id);
    }
}
