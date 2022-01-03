using Microsoft.AspNetCore.Mvc;

namespace STIVE_WEB.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
