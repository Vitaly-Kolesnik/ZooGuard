using System.Collections.Generic;
using System.Linq;
using ZooGuard.Core.Entities.TeamEntities;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Core.Specifications.TeamSpecifications
{
    internal class FindNameCompanySpecification : ISpecification<Company>
    {
        private readonly int UNP;

        public FindNameCompanySpecification(int UNP)
        {
            this.UNP = UNP;
        }

        public IList<string> Includes => null;

        public IQueryable<Company> Apply(IQueryable<Company> query)
        {
            return query.Where(a => a.UNP == UNP);
        }
    }
}
