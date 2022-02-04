using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooGuard.Core.Interfaces
{
    public interface IRepository<TEntity> 
        where TEntity : class
    {
        TEntity Get(int id); //метод, который возвращает id одного объекта
        TEntity Get(ISpecification<TEntity> specification); //метод, который возвращает один объект при передачи объекта типа спецификации
        IList<TEntity> List(); //возвращает весь список значений
        IList<TEntity> List(ISpecification<TEntity> specification); //метод возвращает список по спецификации
        TEntity Add(TEntity entity); //Добавляет сущность
        void Update(TEntity entity); //Вносит изменение в сущность
        void Delete(TEntity entity); //Удаляет сущность
    }
}
