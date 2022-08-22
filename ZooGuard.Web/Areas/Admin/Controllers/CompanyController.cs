using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ZooGuard.Core.Interfaces.InterfaciesForTeamServicies;
using ZooGuard.Web.Interfaces.InterfacesForCompanyViewModelServices;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Areas.Admin.Controllers
{
    [Area("admin")]
    public class CompanyController : Controller
    {
        private readonly ICompanyService companyService;
        private readonly ICompanyViewModelService companyViewModelService;

        public CompanyController(ICompanyService companyService, ICompanyViewModelService companyViewModelService)
        {
            this.companyService = companyService;
            this.companyViewModelService = companyViewModelService;
        }

        [HttpGet("com")]
        public async Task<IActionResult> Companies()
        {
            var list = await companyService.GetAllAsync();

            if (list.Count < 1)
            {
                return RedirectToAction("CompanyListEmpty");
            }
            return View("Companies", list);
        }

        [HttpGet("com/emp")]
        public IActionResult CompanyListEmpty()
        {
            return View("CompanyListEmpty");
        }

        [HttpGet("com/ad")]
        public IActionResult GetFormAddCompany()
        {
            return View("GetFormAddCompany");
        }

        [HttpPost]
        public async Task<IActionResult> AddCompany (ProfileCompanyViewModel companyViewModel)
        {
           if (await companyViewModelService.AddAsync(companyViewModel))
           {
                return RedirectToAction("Companies");
           }

            ModelState.AddModelError(nameof(ProfileCompanyViewModel.UNP), "Such data already exists");
            return RedirectToAction("Companies");
        }
    }
}
