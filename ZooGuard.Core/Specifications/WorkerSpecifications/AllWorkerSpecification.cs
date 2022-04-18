using System.Collections.Generic;
using System.Linq;
using ZooGuard.Core.Entities.MultipleConnections;
using ZooGuard.Core.Entities.WorkerEntities;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Core.Services.WorkerServices
{
    internal class AllWorkerSpecification : ISpecification<Worker>
    {
        public IList<string> Includes => new List<string>()
        {
            $"{nameof(Worker.SpecialitiesOfWorkers)}",
            $"{nameof(Worker.Positions)}",
            $"{nameof(Worker.Place)}",
            $"{nameof(Worker.Storages)}",
            $"{nameof(Worker.WorkersInProjects)}.{nameof(WorkersInProject.Project)}",
            $"{nameof(Worker.WorkersInCompanies)}.{nameof(WorkersInCompany.Company)}",
            $"{nameof(Worker.ServerRooms)}"
        };

        public IQueryable<Worker> Apply(IQueryable<Worker> query)
        {
            return query;
        }
    }
}
