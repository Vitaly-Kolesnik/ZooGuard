using Microsoft.AspNetCore.Mvc;
using ZooGuard.Core.Interfaces;
using ZooGuard.Web.Interfaces;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Controllers
{
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

        [HttpGet ("Vender")]
        public IActionResult GetAllVendersInDataBase()
        {
            var allVenders = venderService.GetAll();

            return View("Index", allVenders);
        }

        [HttpGet ("Vender/Profile/{id}")]
        public IActionResult GetProfileVenderById(int id)
        {
            var vender = venderViewModelService.GetById(id);

            return View("Profile", vender);
        }

        [HttpGet("Vender/AddVender/Form")]
        public IActionResult GetFormAddVender()
        {
            return View("AddVender");
        }

        [HttpPost]
        public IActionResult addVender(VenderViewModel vender)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            int? id = vender.Id;

            if (id == null || id == 0)
            {
                id = venderViewModelService.Add(vender);
            }
            else
            {
                venderViewModelService.Edit(vender);
            }

            return RedirectToAction("GetAllVendersInDataBase");
        }

        [HttpGet("Vender/Edit/{id}")]
        public IActionResult EditVenderById(int id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var vender = venderViewModelService.GetById(id);

            return View("EditVender", vender);
        }

        [HttpGet("Vender/Delete/{id}")]
        public IActionResult DeleteForm (int id)
        {
            var vender = venderViewModelService.GetById(id);
            
            if (vender == null)
            {
                return View();
            }

            return View("Delete", vender);
        }
        
        [HttpPost("Vender/Delete")]
        public IActionResult DeleteVender(int id)
        {
            venderService.Delete(id);

            return RedirectToAction("GetAllVendersInDataBase");
        }
    }
}
