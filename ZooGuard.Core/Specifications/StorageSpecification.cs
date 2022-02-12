using System.Collections.Generic;
using System.Linq;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Core.Specifications
{
    internal class StorageSpecification : ISpecification<Storage>
    {
        public IList<string> Includes => new List<string>
        {
            $"{nameof(Storage.Positions)}.{nameof(Position.User)}"
        };

        public IQueryable<Storage> Apply(IQueryable<Storage> query)
        {
            return query;
        }
    }
}
