using System.Threading.Tasks;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Interfaces
{
    public interface IUserViewModelService
    {
        LoginViewModel GetEmpty();
        Task<bool> SingIn(LoginViewModel model);
        Task<bool> SingOut();
    }
}
