using Microsoft.AspNetCore.Mvc;

namespace MOOD.Controllers
{
    public class CalmController : Controller
    {
        public IActionResult Index()
        {
            return View("../Calm/index");
        }
    }
}
