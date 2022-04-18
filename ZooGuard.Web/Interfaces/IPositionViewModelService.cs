using System.Threading.Tasks;
using ZooGuard.Core.Entities.PositionEntities;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Interfaces
{
    public interface IPositionViewModelService
    {
        Task<bool> AddAsync(PositionViewModel positionViewModel);
        Task<Position> GetPositionByIdAsync(int value);
        Task<PositionViewModel> GetModelByIdAsync(int value);
        Task<bool> EditAsync(PositionViewModel position);
        PositionViewModel GetEmpty();
        Task<bool> DeleteAsync(int id);
    }
}
