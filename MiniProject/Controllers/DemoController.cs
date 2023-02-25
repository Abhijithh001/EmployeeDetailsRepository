using Microsoft.AspNetCore.Mvc;

namespace MiniProject.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
