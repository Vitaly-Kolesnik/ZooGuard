using System.Collections.Generic;
using System.Linq;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Core.Specifications
{
    internal class VenderSpecification : ISpecification<Vender>
    {
        private string name;

        public VenderSpecification(string name)
        {
            this.name = name;
        }

        public IList<string> Includes => null;

        public IQueryable<Vender> Apply(IQueryable<Vender> query)
        {
           return query.Where(p => p.Name.ToLower().IndexOf(name.ToLower()) != -1);
        }
    }
}
