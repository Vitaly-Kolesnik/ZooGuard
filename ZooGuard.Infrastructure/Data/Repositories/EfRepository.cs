using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ZooGuard.Core.Interfaces;
using ZooGuard.Infrastructure;

namespace ZooGuad.Infrastructure.Data.Repositories
{
    //Обощенный репозиторий для работы со всеми сущностями
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
            dbContext.Set<TEntity>().Add(entity);// Set Возвращает DbSet<TEntity> экземпляр для доступа к сущностям заданного типа в контексте и базовом хранилище.
            dbContext.SaveChanges();            // add Начинает отслеживать изменения внесенный в полученный экземпляр сущностей
                                                // SaveChanges сохраняет изменения

            dbContext.Entry(entity).State = EntityState.Detached; //запрет трекинга, выключиталь отслеживания сущности
            return entity;
        }
        public void Delete(TEntity entity) //удаление сущности, для этого нужно передать параметром объект.
        {
            dbContext.Set<TEntity>().Remove(entity);
            dbContext.SaveChanges();
        }
        public TEntity Get(int id) 
        {
            var entity = dbContext.Set<TEntity>().Find(id); //поиск по ключу
            dbContext.Entry(entity).State = EntityState.Detached; //запрет трекинга, выключиталь отслеживания сущности

            return entity;
        }
        public TEntity Get(Specifications<TEntity> specification) //поиск по параметру
        {
            return ApplySpecification(dbContext.Set<TEntity>(), specification).FirstOrDefault();
        }
        public IList<TEntity> List() //возвращает коллекцию объектов на основании сущностей, парсинг не применяется. То есть возврат только категории.
        {
            return dbContext.Set<TEntity>().ToList(); 
        }
        public IList<TEntity> List(Specifications<TEntity> specification) //возвращает коллекицию на основании переданной спецификации
        {
            return ApplySpecification(dbContext.Set<TEntity>(), specification).ToList(); //первый аргумент это коллекция сущностей по позициям, второй - спецификация
        }
        public void Update(TEntity entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;

            dbContext.SaveChanges();
        }
        private IQueryable<TEntity> ApplySpecification(IQueryable<TEntity> source, Specifications<TEntity> specification) //передает коллекцию реализующую IQueryable и спецификацию для обработки
        {
            var result = specification.Apply(source); //вызов спецификации и сохранение результатов в переменную, получаем Iqueryale<TEntity> в именах, которых встречается строка, срока передается в при создании объекта спецификации

            if (specification.Includes != null) 
            {
                foreach (var include in specification.Includes) //проходимся по коллекции (свойству) в спецификации, которая содержит адреса связных таблиц, так как при применении метода Set<TEntity> из базы достается только конкретная таблица, связи будут пустые.
                {
                    result = result.Include(include);
                }
            }
            return result.AsNoTracking();

            //Include принимает Разделенный точками список связанных объектов, включаемых в результаты запроса.
            //возвращает объект запроса. По факту каждую интерацию он будет допихивать данные нашу таблицу
        }
    }
}
