using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ZooGuard.Web.Models;
using ZooGuard.Web.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace ZooGuard.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly IUserViewModelService userViewModelService;
        public AccountController(IUserViewModelService userViewModelService)
        {
            this.userViewModelService = userViewModelService;
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            var result = userViewModelService.GetEmpty();
            return View(result);
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var result = await userViewModelService.SingIn(model);
            if (result == true)
            {
                return Redirect("/StartPage");
            }
            ModelState.AddModelError(nameof(LoginViewModel.Name), "Неверный логин или пароль");
            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            bool result = await userViewModelService.SingOut();
            if (result)
            {
                return RedirectToAction("Login");
            }
            return View();
        }
    }
}

