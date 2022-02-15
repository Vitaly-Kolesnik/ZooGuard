using ZooGuard.Core.Entities;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Interfaces
{
    public interface IUserViewModelService
    {
        int Add(UserViewModel userViewModel);
        User GetUserById(int value);
        UserViewModel GetModelById(int id);
        void Edit(UserViewModel user);
        UserViewModel GetEmpty();
    }
}
