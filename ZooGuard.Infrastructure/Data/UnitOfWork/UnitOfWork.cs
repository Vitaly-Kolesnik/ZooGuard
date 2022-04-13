using System;
using System.Threading.Tasks;
using ZooGuad.Infrastructure.Data.Repositories;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Entities.BaseEntities;
using ZooGuard.Core.Entities.PositionEntities;
using ZooGuard.Core.Entities.StorageEntities;
using ZooGuard.Core.Entities.TeamEntities;
using ZooGuard.Core.Entities.VenderEntities;
using ZooGuard.Core.Entities.WorkerEntities;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Infrastructure.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PositionDbContext dbContext;
        private IRepository<Position> positionRepository;
        private IRepository<Storage> storageRepository;
        private IRepository<Vender> venderRepository;
        private IRepository<Broken> brokenRepository;
        private IRepository<FormOfOccurence> formOfOccurenceRepository;
        private IRepository<Company> companyRepository;
        private IRepository<Place> placeRepository;
        private IRepository<PositionCategory> positionCategoryRepository;
        private IRepository<Project> projectRepository;
        private IRepository<ServerRoom> serverRoomRepository;
        private IRepository<SpecialityWorker> specialityWorkerRepository;
        private IRepository<Worker> workerRepository;

        public UnitOfWork(PositionDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IRepository<Position> PositionRepository
        {
            get
            {
                if (positionRepository == null)
                {
                    positionRepository = new EfRepository<Position>(dbContext);
                }

                return positionRepository;
            }
        }
        public IRepository<Storage> StorageRepository
        {
            get
            {
                if (storageRepository == null)
                {
                    storageRepository = new EfRepository<Storage>(dbContext);
                }
                    
                return storageRepository;
            }
        }
        public IRepository<Vender> VenderRepository
        {
            get
            {
                if (venderRepository == null)
                {
                    venderRepository = new EfRepository<Vender>(dbContext);
                }
                return venderRepository;
            }
        }
        public IRepository<Broken> BrokenRepository 
        { 
            get 
            {
                if (brokenRepository == null)
                {
                    brokenRepository = new EfRepository<Broken>(dbContext);
                }
                return brokenRepository;
            } 
        }
        public IRepository<FormOfOccurence> FormOfOccurenceRepository
        {
            get
            {
                if (formOfOccurenceRepository == null)
                {
                    formOfOccurenceRepository = new EfRepository<FormOfOccurence>(dbContext);
                }
                return formOfOccurenceRepository;
            }
        }
        public IRepository<Place> PlaceRepository
        {
            get
            {
                if (placeRepository == null)
                {
                    placeRepository = new EfRepository<Place>(dbContext);
                }
                return placeRepository;
            }
        }
        public IRepository<PositionCategory> PositionCategoryRepository
        {
            get
            {
                if (positionCategoryRepository == null)
                {
                    positionCategoryRepository = new EfRepository<PositionCategory>(dbContext);
                }
                return positionCategoryRepository;
            }
        }
        public IRepository<Project> ProjectRepository
        {
            get
            {
                if (projectRepository == null)
                {
                    projectRepository = new EfRepository<Project>(dbContext);
                }
                return projectRepository;
            }
        }
        public IRepository<Company> CompanyRepository
        {
            get
            {
                if (companyRepository == null)
                {
                    companyRepository = new EfRepository<Company>(dbContext);
                }
                return companyRepository;
            }
        }
        public IRepository<ServerRoom> ServerRoomRepository
        {
            get
            {
                if (serverRoomRepository == null)
                {
                    serverRoomRepository = new EfRepository<ServerRoom>(dbContext);
                }
                return serverRoomRepository;
            }
        }
        public IRepository<SpecialityWorker> SpecialityWorkerRepository
        {
            get
            {
                if (specialityWorkerRepository == null)
                {
                    specialityWorkerRepository = new EfRepository<SpecialityWorker>(dbContext);
                }
                return specialityWorkerRepository;
            }
        }
        public IRepository<Worker> WorkerRepository
        {
            get
            {
                if (workerRepository == null)
                {
                    workerRepository = new EfRepository<Worker>(dbContext);
                }
                return workerRepository;
            }
        }
        public IRepository<T> GetRepository<T>() where T : BaseStorageEntities => new EfRepository<T>(dbContext);
        public async Task<bool> SaveAsync()
        {
            await dbContext.SaveChangesAsync();
            return true;
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
                disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
