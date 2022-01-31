using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooGuard.Core.Entites;
using ZooGuard.Core.Entites.InfoAboutPos;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Core.Specifications
{
    internal class PositionInformationSpecification : ISpecification<_InformationAboutPosition> 
    {
        private string name;
        public PositionInformationSpecification(string name)
        {
            this.name = name;
        }
        public IList<string> Includes => null;

        public IQueryable<_InformationAboutPosition> Apply(IQueryable<_InformationAboutPosition> source)
        {
            return source.Where(p => p.Name.ToLower().IndexOf(name.ToLower()) != -1);
        }
    }
}
