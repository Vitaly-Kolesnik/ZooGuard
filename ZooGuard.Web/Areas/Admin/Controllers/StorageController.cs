using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ZooGuard.Core.Interfaces;
using ZooGuard.Web.Interfaces;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Controllers
{
    [Area("admin")]
    public class StorageController : Controller
    {
        private readonly IStorageViewModelService storageViewModelService;

        public StorageController(IStorageViewModelService storageViewModelService)
        {
            this.storageViewModelService = storageViewModelService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("st")]
        public async Task<IActionResult> Storagies()
        {
            return View("Storagies");
        }
    }
}
