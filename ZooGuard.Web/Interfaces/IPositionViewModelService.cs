using ZooGuard.Core.Entities;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Interfaces
{
    public interface IPositionViewModelService
    {
        int Add(PositionViewModel positionViewModel);
        Position GetPositionById(int value);
        PositionViewModel GetModelById(int value);
        void Edit(PositionViewModel position);
        PositionViewModel GetEmpty();
    }
}
