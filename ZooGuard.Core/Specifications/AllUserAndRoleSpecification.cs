using System.Collections.Generic;
using System.Linq;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Core.Specifications
{
    internal class AllUserAndRoleSpecification : Specifications<User>
    {
        public IList<string> Includes => new List<string> { $"{nameof(User.Members)}.{nameof(Member.Role)}"};

        public IQueryable<User> Apply(IQueryable<User> query)
        {
            return query;
        }
    }
}
