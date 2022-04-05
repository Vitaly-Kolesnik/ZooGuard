using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
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
            return Redirect("~/sp"); 
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

        [Authorize(Roles = "admin")]
        public IActionResult Roles()
        {
            return View();
        }
    }
}
