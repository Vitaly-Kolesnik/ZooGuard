using Microsoft.AspNetCore.Mvc;

namespace ZooGuard.Web.Controllers
{
    public class StorageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
