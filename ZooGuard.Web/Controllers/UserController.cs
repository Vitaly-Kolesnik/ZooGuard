using Microsoft.AspNetCore.Mvc;
using ZooGuard.Core.Interfaces;
using ZooGuard.Web.Interfaces;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Controllers
{
    public class UserController : Controller
    {
       private readonly IUserViewModelService userViewModelService;
        private readonly IUserService userService;

        public UserController(IUserService userServise, IUserViewModelService userViewModelService)
        {
            this.userService = userServise;
            this.userViewModelService = userViewModelService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllUsersInDataBase() //наименование метода должно совыпадать с Title во View
        {
            var allUsers = userService.GetAll();

            return View("Index", allUsers);
        }

        [HttpGet("User/AddUser/Form")]
        public IActionResult GetUserForm()
        {
            var form = userViewModelService.GetEmpty();
            return View("AddUser", form);
        }
        
        [HttpPost]
        public IActionResult AddUser(UserViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            int? id = user.Id;

            if (id == null || id == 0)
            {
                id = userViewModelService.Add(user);
            }
            else
            {
                userViewModelService.Edit(user);
            }

            return RedirectToAction("GetAllUsersInDataBase");
        }

        [HttpGet("User/Profile/{id}")]
        public IActionResult GetProfileUserById(int id)
        {
            var position = userViewModelService.GetUserById(id);

            return View("Profile", position);
        }

        [HttpGet("User/Edit/{id}")]
        public IActionResult EditUserById(int id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var user = userViewModelService.GetModelById(id);

            return View("EditUser", user);
        }

        [HttpGet("User/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var position = userViewModelService.GetModelById(id);

            if (position == null)
            {
                return View();
            }

            return View("Delete", position);
        }

        [HttpPost("User/Delete")]
        public IActionResult DeleteUser(int id)
        {
            userService.Delete(id);

            return RedirectToAction("GetAllUsersInDataBase");
        }
    }
}
