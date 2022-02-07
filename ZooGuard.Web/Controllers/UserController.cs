using Microsoft.AspNetCore.Mvc;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Web.Controllers
{
    public class UserController : Controller
    {
        //private readonly IPositionViewModelService positionViewModelService;
        private readonly IUserService UserService;

        public UserController(IUserService userServise)
        {
            this.UserService = userServise;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllUsersInDataBase() //наименование метода должно совыпадать с Title во View
        {
            var allUsers = UserService.GetAll();

            return View("Index", allUsers);
        }
    }
}
