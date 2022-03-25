using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using ZooGuard.Web.Interfaces;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Services
{
    public class UserViewModelService : IUserViewModelService
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        public UserViewModelService(UserManager<IdentityUser> userMgr, SignInManager<IdentityUser> signinMgr)
        {
            userManager = userMgr;
            signInManager = signinMgr;
        }
        public LoginViewModel GetEmpty()
        {
            return new LoginViewModel();
        }

        public async Task<bool> SingIn(LoginViewModel model)
        {
            IdentityUser user = await userManager.FindByNameAsync(model.Name);
            if (user != null)
            {
                await signInManager.SignOutAsync();
                SignInResult result = await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    return true;
                }
            }
            return false;
        }

        public async Task<bool> SingOut()
        {
            await signInManager.SignOutAsync();
            return true;
        }
    }
}
    

