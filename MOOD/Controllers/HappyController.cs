using Microsoft.AspNetCore.Mvc;

namespace MOOD.Controllers
{
    public class HappyController : Controller
    {
        public IActionResult Index()
        {
            return View("../Happy/index");
        }
    }
}
