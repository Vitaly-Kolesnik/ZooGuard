using ZooGuard.Web.Models;

namespace ZooGuard.Web.Interfaces
{
    public interface IStatusViewModelService
    {
        int Add(StatusViewModel statusViewModel);
        StatusViewModel GetById(int value);
        void Edit(StatusViewModel user);
        StatusViewModel GetEmpty();
    }
}
