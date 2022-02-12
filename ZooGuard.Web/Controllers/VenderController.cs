using Microsoft.AspNetCore.Mvc;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Web.Controllers
{
    public class VenderController : Controller
    {
        private readonly IVenderService venderService;

        public VenderController(IVenderService venderService)
        {
            this.venderService = venderService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllVendersInDataBase ()
        {
            var allVenders = venderService.GetAll();

            return View("Index", allVenders);
        }
    }
}
