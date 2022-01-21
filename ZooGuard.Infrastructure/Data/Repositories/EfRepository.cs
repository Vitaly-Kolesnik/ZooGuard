using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ZooGuard.Core.Interfaces;
using ZooGuard.Infrastructure;

namespace ZooGuad.Infrastructure.Data.Repositories
{
    public class EfRepository<TEntity> : IRepository<TEntity>
      where TEntity : class
    {
        private readonly PositionDbContext dbContext;
        public EfRepository(PositionDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public TEntity Add(TEntity entity)
        {
            dbContext.Set<TEntity>().Add(entity);
            dbContext.SaveChanges();

            dbContext.Entry(entity).State = EntityState.Detached; //запрет трекинга

            return entity;
        }
        public void Delete(TEntity entity)
        {
            dbContext.Set<TEntity>().Remove(entity);
            dbContext.SaveChanges();
        }
        public TEntity Get(int id)
        {
            var entity = dbContext.Set<TEntity>().Find(id);
            dbContext.Entry(entity).State = EntityState.Detached;

            return entity;
        }
        public TEntity Get(ISpecification<TEntity> specification)
        {
            return specification
             .Apply(dbContext.Set<TEntity>())
             .AsNoTracking()
             .FirstOrDefault();
        }
        public IList<TEntity> List()
        {
            return dbContext.Set<TEntity>().ToList();
        }
        public IList<TEntity> List(ISpecification<TEntity> specification)
        {
            return specification
              .Apply(dbContext.Set<TEntity>())
              .AsNoTracking()
              .ToList();
        }
        public void Update(TEntity entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;

            dbContext.SaveChanges();
        }
    }
}
