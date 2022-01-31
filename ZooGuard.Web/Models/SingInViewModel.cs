using System.ComponentModel.DataAnnotations;

namespace ZooGuard.Web.Models
{
    //Вызывается контроллером, после обращения контроллера к приложению. Модель представления фиксирует детали,
    //необходимые для того, что бы представление сгенерировало ответ.
    public class SingInViewModel
    {
       [Required] //Говорит, что данное свойство должно быть обязательно установлено
       public string Login { get; set; }

       [Required, DataType(DataType.Password)]
            //Для свойства с атрибутом DataType.Password HTML-хелперы создают элемент ввода, у которого атрибут type имеет значение "password".
            //Тогда в браузере вы при вводе данных вы не увидите вводимые символы
       public string Password { get; set; }
    }
    
}