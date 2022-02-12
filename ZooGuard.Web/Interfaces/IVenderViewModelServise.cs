using ZooGuard.Web.Models;

namespace ZooGuard.Web.Interfaces
{
    public interface IVenderViewModelService
    {
        int Add(VenderViewModel venderViewModel);
        VenderViewModel GetById(int id);
        void Edit(VenderViewModel vender);
        VenderViewModel GetEmpty();
    }
}
