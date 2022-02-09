using System.Collections.Generic;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Specifications;

namespace ZooGuard.Core.Services
{
    public class VenderService : IVenderService
    {
        private readonly IRepository<Vender> repositoryVender;

        public VenderService (IRepository<Vender> repository)
        {
            this.repositoryVender = repository;
        }
        
        public int Add(Vender vender)
        {
            repositoryVender.Add(vender);
            return vender.Id;
        }

        public void Delete(int id)
        {
            repositoryVender.Delete(new Vender { Id = id });
        }

        public Vender Get(int id)
        {
            return repositoryVender.Get(id);
        }

        public IList<Vender> GetAll()
        {
            return repositoryVender.List();
        }

        public IList<Vender> List(string name)
        {
            return repositoryVender.List(new VenderSpecification(name));
        }

        public int Update(Vender vender)
        {
            repositoryVender.Update(vender);
            return(vender.Id);
        }
    }
}
