using Microsoft.AspNetCore.Mvc;

namespace MOOD.Controllers
{
    public class BreathingController : Controller
    {
        public IActionResult Index()
        {
            return View("../Breathing/index");
        }
    }
}
