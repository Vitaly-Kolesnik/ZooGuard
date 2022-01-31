using System.Collections.Generic;
using ZooGuard.Core.Entites.InfoAboutPos;

namespace ZooGuard.Core.Interfaces
{
    public interface IPositionInformationService <TInformation> 
    {
        int Add(TInformation informationAboutPosition); //Добавление информационно позиции
        TInformation Get(int id); //Поиск информационной позиции по id
        void Delete(int id); //Удаление информационной позиции id
        List<TInformation> List(string name); //поиск по строке
        int Update(TInformation informationAboutPosition); //изменение информационной позиции
        List<TInformation> GetAll(); //возврат всех информационных позиций
    }
}
