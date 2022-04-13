using System.Collections.Generic;
using System.Linq;
using ZooGuard.Core.Entities.BaseEntities;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Core.Specifications
{
    internal class PositionInformationSpecification <T> : ISpecification<T>  
        where T : BaseStorageEntities
    {
        private string name;
        public PositionInformationSpecification(string name)
        {
            this.name = name;
        }
        public IList<string> Includes => null;

        public IQueryable<T> Apply(IQueryable<T> source)
        {
            return source.Where(p => p.Name.ToLower().IndexOf(name.ToLower()) != -1);
        }
    }
}
