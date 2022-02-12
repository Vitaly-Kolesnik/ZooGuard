using ZooGuard.Web.Models;

namespace ZooGuard.Web.Interfaces
{
    public interface IUserViewModelService
    {
        int Add(UserViewModel userViewModel);
        UserViewModel GetById(int value);
        void Edit(UserViewModel user);
        UserViewModel GetEmpty();
    }
}
