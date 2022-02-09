using Microsoft.AspNetCore.Mvc;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Web.Controllers
{
    public class StorageController : Controller
    {
        private readonly IStorageService storageService;

        public StorageController(IStorageService storageService)
        {
            this.storageService = storageService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllStoragesInDataBase() //наименование метода должно совыпадать с Title во View
        {
            var allStorages = storageService.GetAll();

            return View("Index", allStorages); //Возвращает View c наименование Index и Title - GetAllPositionInDataBase
        }


    }
}
