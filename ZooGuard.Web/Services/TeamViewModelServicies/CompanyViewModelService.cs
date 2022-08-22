using System.Threading.Tasks;
using ZooGuard.Core.Entities.TeamEntities;
using ZooGuard.Core.Interfaces.InterfaciesForTeamServicies;
using ZooGuard.Web.Interfaces.InterfacesForCompanyViewModelServices;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Services
{
    public class CompanyViewModelService :ICompanyViewModelService
    {
        private readonly ICompanyService companyService;

        public CompanyViewModelService(ICompanyService companyService)
        {
            this.companyService = companyService;
        }

        public async Task<bool> AddAsync(ProfileCompanyViewModel companyViewModel)
        {
           return await companyService.AddAsync(ConvertToModel(companyViewModel));
        }

        public ProfileCompanyViewModel GetEmpty ()
        {
            return new ProfileCompanyViewModel();
        }

        private Company ConvertToModel (ProfileCompanyViewModel companyViewModel)
        {
            return new Company
            {
                Id = companyViewModel.Id ?? 0,
                OrgForm = companyViewModel.OrgForm,
                Name = companyViewModel.Name,
                UNP = companyViewModel.UNP,
                Adress = companyViewModel.Adress
            };
        }
    }
}
