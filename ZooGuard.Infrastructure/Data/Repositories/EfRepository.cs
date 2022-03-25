using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<bool> AddAsync(TEntity entity)
        {
            await dbContext.Set<TEntity>().AddAsync(entity);// Set Возвращает DbSet<TEntity> экземпляр для доступа к сущностям заданного типа в контексте и базовом хранилище.
            await dbContext.SaveChangesAsync();            // add Начинает отслеживать изменения внесенный в полученный экземпляр сущностей
            await Task.Run(() => dbContext.Entry(entity).State = EntityState.Detached); //запрет трекинга, выключиталь отслеживания сущности
            
            return true;
        }
        public async Task<bool> DeleteAsync(TEntity entity) //удаление сущности, для этого нужно передать параметром объект.
        {
            await Task.Run (() => dbContext.Set<TEntity>().Remove(entity));
            await dbContext.SaveChangesAsync();

            return true;
        }
        public async Task <TEntity> GetAsync(int id) 
        {
            var entity = await dbContext.Set<TEntity>().FindAsync(id); //поиск по ключу

            await Task.Run(() => dbContext.Entry(entity).State = EntityState.Detached); //запрет трекинга, выключиталь отслеживания сущности

            return entity;
        }
        public async Task <TEntity> GetAsync(Specifications<TEntity> specification) //поиск по параметру
        {
            return await ApplySpecification(dbContext.Set<TEntity>(), specification).FirstOrDefaultAsync();
        }
        public async Task <IList<TEntity>> ListAsync() //возвращает коллекцию объектов на основании сущностей, парсинг не применяется. То есть возврат только категории.
        {
            return await dbContext.Set<TEntity>().ToListAsync(); 
        }
        public async Task< IList<TEntity>> ListAsync(Specifications<TEntity> specification) //возвращает коллекицию на основании переданной спецификации
        {
            return await ApplySpecification(dbContext.Set<TEntity>(), specification).ToListAsync(); //первый аргумент это коллекция сущностей по позициям, второй - спецификация
        }
        public async Task <bool> UpdateAsync(TEntity entity)
        {
            await Task.Run (() => dbContext.Entry(entity).State = EntityState.Modified);

            await dbContext.SaveChangesAsync();

            return true;
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
