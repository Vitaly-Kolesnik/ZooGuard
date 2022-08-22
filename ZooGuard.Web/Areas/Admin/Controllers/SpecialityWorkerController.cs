using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ZooGuard.Core.Interfaces.InterfaciesForWorkerServicies;

namespace ZooGuard.Web.Areas.Admin.Controllers
{
    [Area("admin")]
    public class SpecialityWorkerController : Controller
    {
        private readonly ISpecialityWorkerService workerSpecialityService;

        public SpecialityWorkerController(ISpecialityWorkerService workerSpecialityService)
        {
            this.workerSpecialityService = workerSpecialityService;
        }

        [HttpGet("spc")]
        public async Task<IActionResult> Speciality()
        {
            var list = await workerSpecialityService.GetAllAsync();

            if (list.Count < 1)
            {
                return RedirectToAction("SpecialityListEmpty");
            }
            return View("Specialty", list);
        }

        [HttpGet("spc/emp")]
        public IActionResult SpecialityListEmpty()
        {
            return View("SpecialityListEmpty");
        }

        [HttpGet("spc/ad")]
        public IActionResult GetFormAddSpeciality()
        {
            return View("GetFormAddSpeciality");
        }
    }
}
