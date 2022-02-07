using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooGuard.Core.Entities.InfoAboutPos;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Specifications;

namespace ZooGuard.Core.Services
{
    public class PositionInformationService<TInformation> : IPositionInformationService<TInformation> 
        where TInformation : InformationAboutPosition, new()
    {
        private readonly IRepository<TInformation> informationPositionRepository;

        public PositionInformationService(IRepository<TInformation> informationPositionRepository)
        {
            this.informationPositionRepository = informationPositionRepository;
        }

        public int Add(TInformation informationAboutPosition)
        {
            informationPositionRepository.Add(informationAboutPosition);
            return informationAboutPosition.Id;
        }

        public void Delete(int id)
        {
            informationPositionRepository.Delete(new TInformation { Id = id });
        }

        public TInformation Get(int id)
        {
            return informationPositionRepository.Get(id);
        }

        public IList<TInformation> GetAll()
        {
            return informationPositionRepository.List();
        }

        public IList<TInformation> List(string name)
        {
            var specification = new PositionInformationSpecification<TInformation>(name);

            return informationPositionRepository.List(specification); // в данном случае ему по факту надо указать какая будет именно спецификация, так как описано в интерфейсе
        }
        public int Update(TInformation informationAboutPosition)
        {
            informationPositionRepository.Update(informationAboutPosition);
            return informationAboutPosition.Id;
        }
    }
}
