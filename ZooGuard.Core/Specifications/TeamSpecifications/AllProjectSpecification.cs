using System.Collections.Generic;
using System.Linq;
using ZooGuard.Core.Entities.MultipleConnections;
using ZooGuard.Core.Entities.TeamEntities;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Core.Specifications.TeamSpecifications
{
    internal class AllProjectSpecification : ISpecification<Project>
    {
        public IList<string> Includes => new List<string>()
        {
            $"{nameof(Project.Positions)}",
            $"{nameof(Project.Places)}",
            $"{nameof(Project.WorkersInProjects)}.{nameof(WorkersInProject.Worker)}",
            $"{nameof(Project.Places)}"
        };

        public IQueryable<Project> Apply(IQueryable<Project> query)
        {
            return query;
        }
    }
}
