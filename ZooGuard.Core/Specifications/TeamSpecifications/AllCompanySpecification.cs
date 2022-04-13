using System.Collections.Generic;
using System.Linq;
using ZooGuard.Core.Entities.MultipleConnections;
using ZooGuard.Core.Entities.TeamEntities;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Core.Specifications.TeamSpecifications
{
    internal class AllCompanySpecification : ISpecification<Company>
    {
        public IList<string> Includes => new List<string>()
        {
            $"{nameof(Company.Positions)}",
            $"{nameof(Company.Projects)}",
            $"{nameof(Company.Storages)}",
            $"{nameof(Company.Places)}",
            $"{nameof(Company.ServerRooms)}",
            $"{nameof(Company.WorkersInCompanies)}.{nameof(WorkersInCompany.Worker)}"
        };

        public IQueryable<Company> Apply(IQueryable<Company> query)
        {
            return query;
        }
    }
}
