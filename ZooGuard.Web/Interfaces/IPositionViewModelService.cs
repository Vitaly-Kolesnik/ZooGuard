using ZooGuard.Web.Models;

namespace ZooGuard.Web.Interfaces
{
    public interface IPositionViewModelService
    {
        int Add(PositionViewModel positionViewModel);
        PositionViewModel GetById(int value);
        void Edit(PositionViewModel position);
        PositionViewModel GetEmpty();
    }
}
