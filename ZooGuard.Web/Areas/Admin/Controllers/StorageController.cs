using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
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
        public async Task<IActionResult> GetAllStoragesInDataBase() //наименование метода должно совыпадать с Title во View
        {

            var allStorages = await storageService.GetAllAsync();

            return View("Index", allStorages); //Возвращает View c наименование Index и Title - GetAllPositionInDataBase
        }

        [HttpGet("Storage/Profile/{id}")]
        public async Task<IActionResult> GetProfileStorageById(int id)
        {
            var vender = await storageViewModelService.GetByIdAsync(id);

            return View("Profile", vender);
        }

        [HttpGet("Storage/AddStorage/Form")]
        public IActionResult GetFormAddStorage()
        {
            return View("AddStorage");
        }

        [HttpPost]
        public async Task<IActionResult> AddStorageAsync(StorageViewModel storage)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            int? id = storage.Id;

            if (id == null || id == 0)
            {
                _ = await storageViewModelService.AddAsync(storage);
            }
            else
            {
               await storageViewModelService.EditAsync(storage);
            }
            return RedirectToAction("GetAllStoragesInDataBase");
        }

        [HttpGet("Storage/Edit/{id}")]
        public async Task<IActionResult> EditStorageById(int id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var storage = await storageViewModelService.GetByIdAsync(id);

            return View("EditStorage", storage);
        }

        [HttpGet("Storage/Delete/{id}")]
        public async Task<IActionResult> DeleteForm(int id)
        {
            var storage = await storageViewModelService.GetByIdAsync(id);

            if (storage == null)
            {
                return View();
            }

            return View("Delete", storage);
        }

        [HttpPost("Storage/Delete")]
        public async Task<IActionResult> DeleteStorage(int id)
        {
            _= await storageViewModelService.DeleteAsync(id);

            return RedirectToAction("GetAllStoragesInDataBase");
        }
    }
}
