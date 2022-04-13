using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using ZooGuard.Core.Interfaces.InterfaciesForTeamServicies;

namespace ZooGuard.Web.Areas.Admin.Controllers
{
    [Area("admin")]
    public class CompanyController : Controller
    {
        private ICompanyService companyService;

        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService;
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
    }
}
