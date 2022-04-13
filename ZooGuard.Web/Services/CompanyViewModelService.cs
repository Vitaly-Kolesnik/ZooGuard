using System.Threading.Tasks;
using ZooGuard.Core.Interfaces.InterfaciesForTeamServicies;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Services
{
    public class CompanyViewModelService
    {
        private ICompanyService companyService;

        public CompanyViewModelService(ICompanyService companyService)
        {
            this.companyService = companyService;
        }
    }
}
