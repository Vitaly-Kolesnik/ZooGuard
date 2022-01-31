using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooGuard.Core.Entites.InfoAboutPos;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Specifications;

namespace ZooGuard.Core.Services
{
    public class PositionInformationService<TInformation> : IPositionInformationService<TInformation> 
        where TInformation : _InformationAboutPosition, new()
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

        public List<TInformation> GetAll()
        {
            return informationPositionRepository.List().ToList();
        }

        public List<TInformation> List(string name)
        {
            var specification = (ISpecification<TInformation>) new PositionInformationSpecification(name);

            return informationPositionRepository.List(specification).ToList(); // в данном случае ему по факту надо указать какая будет именно спецификация, так как описано в интерфейсе
        }
        public int Update(TInformation informationAboutPosition)
        {
            informationPositionRepository.Update(informationAboutPosition);
            return informationAboutPosition.Id;
        }
    }
}
