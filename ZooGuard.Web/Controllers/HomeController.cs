using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Controllers
{
    public class HomeController : Controller
    {
    //Генерация ответа на запрос:
    //данные в модели привязки действительны для запроса,
    //вызов соответствующих действий в модели приложения с помощью сервисов,
    //выбрать соответствующий ответ на основании ответа от модели приложения
        
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger) //Сервис Logger предоставляется с помощью внедрения зависимости
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Здесь может быть вызов контретного сервиса (метода сервиса) из бизнес логики
            // передача данных в модель предстапвления

            // не выполняет бизнес-логики напрямую.

            return View(); //указывает представлению, что оно должно вернуть пользователю
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
