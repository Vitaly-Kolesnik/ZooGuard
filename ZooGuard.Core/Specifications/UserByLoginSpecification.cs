using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Core.Specifications
{
    internal class UserByLoginSpecification : ISpecification<User>
    {
        private string login;
        public IList<string> Includes =>
            new List<string> { $"{nameof(User.Members)}.{nameof(Member.Role)}" }; //более актуальная версия

        public UserByLoginSpecification(string login)
        {
            this.login = login;
        }

        public IQueryable<User> Apply(IQueryable<User> query)
        {
            return query.Where(i => i.Login == login);
        }
    }
}
