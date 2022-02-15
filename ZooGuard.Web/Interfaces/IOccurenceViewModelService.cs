using ZooGuard.Web.Models;

namespace ZooGuard.Web.Interfaces
{
    public interface IOccurenceViewModelService
    {
        int Add(OccurenceViewModel occurenceViewModel);
        OccurenceViewModel GetById(int id);
        void Edit(OccurenceViewModel occurence);
        OccurenceViewModel GetEmpty();
    }
}
