using System.Threading.Tasks;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Interfaces.InterfacesForCompanyViewModelServices
{
    public interface ICompanyViewModelService
    {
        Task<CompanyViewModel> GetAll();
    }
}
