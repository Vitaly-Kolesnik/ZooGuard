using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ZooGuard.Web
{
    public class Program
    {
    //Класс Program - это место, где настраивают инфраструктуру приложения, такую как HTTP-сервер, интеграцию с IIS и источники конфигурирования
        public static void Main(string[] args)
        {
            CreateHostBuilder(args) //создаем IHost из IHostBuilder 
                .Build() //IHost - ядро приложения, содержащее конфигурацию приложения и сервер Kestrel (метод расширения)
                .Run(); //Запускаем IHost и начинаем прослушивать запросы и генерировать ответы (метод расширения)
        }

        //Реализация паттерна строитель
        public static IHostBuilder CreateHostBuilder(string[] args) => 
            Host.CreateDefaultBuilder(args) //создаем IHOSTBuilder используя конфигурацию по умолчанию (Универсальный узел для любых UI)
                .ConfigureWebHostDefaults(webBuilder => //Настраиваем приложение для использования Kestrel и прослушивания HTTP-запросов (Web app)
                {
                    webBuilder.UseStartup<Startup>(); //Класс Startup определяет конфигурации проекта (внутри метода организована рифлексия, то есть необходимые элементы находтся при запуске)
                                                     
                });
    }
}
