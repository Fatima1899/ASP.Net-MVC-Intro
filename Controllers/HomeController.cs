using Microsoft.AspNetCore.Mvc;

namespace products.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
