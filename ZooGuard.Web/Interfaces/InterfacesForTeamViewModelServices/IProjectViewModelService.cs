using System.Threading.Tasks;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Interfaces.InterfacesForTeamViewModelServices
{
    public interface IProjectViewModelService
    {
        Task<bool> AddAsync(ProjectViewModel projectViewModel);
    }
}
