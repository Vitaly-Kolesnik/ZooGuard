using Microsoft.AspNetCore.Mvc;
using ZooGuard.Core.Interfaces;
using ZooGuard.Web.Interfaces;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Controllers
{
    public class StorageController : Controller
    {
        private readonly IStorageService storageService;
        private readonly IStorageViewModelService storageViewModelService;

        public StorageController(IStorageService storageService, IStorageViewModelService storageViewModelService)
        {
            this.storageService = storageService;
            this.storageViewModelService = storageViewModelService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet ("Storage")]
        public IActionResult GetAllStoragesInDataBase() //наименование метода должно совыпадать с Title во View
        {
            var allStorages = storageService.GetAll();

            return View("Index", allStorages); //Возвращает View c наименование Index и Title - GetAllPositionInDataBase
        }

        [HttpGet("Storage/Profile/{id}")]
        public IActionResult GetProfileStorageById(int id)
        {
            var vender = storageViewModelService.GetById(id);

            return View("Profile", vender);
        }

        [HttpGet("Storage/AddStorage/Form")]
        public IActionResult GetFormAddStorage()
        {
            return View("AddStorage");
        }

        [HttpPost]
        public IActionResult addStorage(StorageViewModel storage)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            int? id = storage.Id;

            if (id == null || id == 0)
            {
                id = storageViewModelService.Add(storage);
            }
            else
            {
                storageViewModelService.Edit(storage);
            }
            return RedirectToAction("GetAllStoragesInDataBase");
        }

        [HttpGet("Storage/Edit/{id}")]
        public IActionResult EditStorageById(int id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var storage = storageViewModelService.GetById(id);

            return View("EditStorage", storage);
        }

        [HttpGet("Storage/Delete/{id}")]
        public IActionResult DeleteForm(int id)
        {
            var storage = storageViewModelService.GetById(id);

            if (storage == null)
            {
                return View();
            }

            return View("Delete", storage);
        }

        [HttpPost("Storage/Delete")]
        public IActionResult DeleteStorage(int id)
        {
            storageService.Delete(id);

            return RedirectToAction("GetAllStoragesInDataBase");
        }
    }
}
