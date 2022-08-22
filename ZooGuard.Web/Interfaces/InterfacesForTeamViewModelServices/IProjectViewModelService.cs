using System.Threading.Tasks;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Interfaces.InterfacesForTeamViewModelServices
{
    public interface IProjectViewModelService
    {
        Task<bool> AddAsync(ProfileProjectViewModel projectViewModel);

        ProfileProjectViewModel GetEmpty();

        Task<bool> DeleteProjectAsync(int id);

        Task<ProfileProjectViewModel> GetProjectByIdAsync(int id);

    }
}
