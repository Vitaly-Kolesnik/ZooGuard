using System.Collections.Generic;
using System.Linq;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Entities.StorageEntities;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Core.Specifications
{
    internal class StorageSpecification : ISpecification<Storage>
    {
        public IList<string> Includes => new List<string>
        {
            $"{nameof(Storage.Positions)}"
        };

        public IQueryable<Storage> Apply(IQueryable<Storage> query)
        {
            return query;
        }
    }
}
