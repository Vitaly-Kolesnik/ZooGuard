using System.Collections.Generic;
using ZooGuard.Core.Entities.InfoAboutPos;

namespace ZooGuard.Core.Interfaces
{
    public interface IPositionInformationService <TInformation> 
        where TInformation : InformationAboutPosition, new() //обязательно условие для типобезопсаности
    {
        int Add(TInformation informationAboutPosition); //Добавление информационно позиции
        TInformation Get(int id); //Поиск информационной позиции по id
        void Delete(int id); //Удаление информационной позиции id
        IList<TInformation> List(string name); //поиск по строке
        int Update(TInformation informationAboutPosition); //изменение информационной позиции
        IList<TInformation> GetAll(); //возврат всех информационных позиций
    }
}
