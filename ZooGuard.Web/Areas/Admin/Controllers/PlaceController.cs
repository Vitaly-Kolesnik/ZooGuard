using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ZooGuard.Core.Entities.StorageEntities;
using ZooGuard.Core.Interfaces;
using ZooGuard.Web.Interfaces.InterfacesForStorageViewModelServices;

namespace ZooGuard.Web.Areas.Admin.Controllers
{
    [Area("admin")]
    public class PlaceController : Controller
    {
        private readonly IAllStorageService<Place> placeService;
        private readonly IPlaceViewModelService placeViewModelService;

        public PlaceController(IAllStorageService<Place> placeService, IPlaceViewModelService placeViewModelService)
        {
            this.placeService = placeService;
            this.placeViewModelService = placeViewModelService;
        }

        [HttpGet("pl")]
        public async Task<IActionResult> Places()
        {
            var list = await placeService.GetAllAsync();

            if (list.Count < 1)
            {
                return RedirectToAction("PlaceListEmpty");
            }
            return View("Places", list);
        }

        [HttpGet("pl/emp")]
        public IActionResult PlaceListEmpty()
        {
            return View("PlaceListEmpty");
        }

        [HttpGet("pl/ad")]
        public IActionResult GetFormAddPlace()
        {
            var model = placeViewModelService.GetEmpty();

            return View("GetFormAddPlace", model);
        }
    }
}
