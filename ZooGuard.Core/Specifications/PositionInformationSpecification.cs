using System.Collections.Generic;
using System.Linq;
using ZooGuard.Core.Entities.InfoAboutPos;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Core.Specifications
{
    internal class PositionInformationSpecification <TInformation> : Specifications<TInformation>  
        where TInformation : InformationAboutPosition //на этом уровне мы замыкаем как раз круг обобщений, поддерживая такми образом типобезопасность
    {
        private string name;
        public PositionInformationSpecification(string name)
        {
            this.name = name;
        }
        public IList<string> Includes => null;

        public IQueryable<TInformation> Apply(IQueryable<TInformation> source)
        {
            return source.Where(p => p.Name.ToLower().IndexOf(name.ToLower()) != -1);
        }
    }
}
