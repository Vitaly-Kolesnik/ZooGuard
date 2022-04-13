using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ZooGuard.Core.Interfaces.InterfacesForVenderServicies;
using ZooGuard.Web.Interfaces;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Controllers
{
    [Area("admin")]
    public class VenderController : Controller
    {
        private readonly IVenderService venderService;
        private readonly IVenderViewModelService venderViewModelService;

        public VenderController(IVenderService venderService, IVenderViewModelService venderViewModelService)
        {
            this.venderService = venderService;
            this.venderViewModelService = venderViewModelService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("vn")]
        public async Task<IActionResult> Venders()
        {
            return View("Venders");
        }

        [HttpGet ("Vender")]
        public async Task<IActionResult> GetAllVendersInDataBase()
        {
            var allVenders = await venderService.GetAllAsync();

            return View("Index", allVenders);
        }

        [HttpGet ("Vender/Profile/{id}")]
        public async Task<IActionResult> GetProfileVenderById(int id)
        {
            var vender = await venderViewModelService.GetByIdAsync(id);

            return View("Profile", vender);
        }

        [HttpGet("Vender/AddVender/Form")]
        public IActionResult GetFormAddVender()
        {
            return View("AddVender");
        }

        [HttpPost]
        public async Task<IActionResult> AddVender(VenderViewModel vender)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            int? id = vender.Id;

            if (id == null || id == 0)
            {
                _ = await venderViewModelService.AddAsync(vender);
            }
            else
            {
                _ = await venderViewModelService.EditAsync(vender);
            }

            return RedirectToAction("GetAllVendersInDataBase");
        }

        [HttpGet("Vender/Edit/{id}")]
        public async Task<IActionResult> EditVenderById(int id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var vender = await venderViewModelService.GetByIdAsync(id);

            return View("EditVender", vender);
        }

        [HttpGet("Vender/Delete/{id}")]
        public async Task<IActionResult> DeleteForm (int id)
        {
            var vender = await venderViewModelService.GetByIdAsync(id);
            
            if (vender == null)
            {
                return View();
            }

            return View("Delete", vender);
        }
        
        [HttpPost("Vender/Delete")]
        public async Task<IActionResult> DeleteVender(int id)
        {
            _= await venderViewModelService.DeleteAsync(id);

            return RedirectToAction("GetAllVendersInDataBase");
        }
    }
}
