using System;
using System.Threading.Tasks;
using ZooGuad.Infrastructure.Data.Repositories;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Entities.InfoAboutPos;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Infrastructure.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PositionDbContext dbContext;
        private IRepository<Position> positionRepository;
        private IRepository<Storage> storageRepository;
        private IRepository<Vender> venderRepository;

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

        public IRepository<T> GetRepository<T>() where T : InformationAboutPosition => new EfRepository<T>(dbContext);

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
