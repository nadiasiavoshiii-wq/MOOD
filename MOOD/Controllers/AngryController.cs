using Microsoft.AspNetCore.Mvc;

namespace MOOD.Controllers
{
    public class AngryController : Controller
    {
        public IActionResult Index()
        {
            return View("../Angry/index");
        }
    }
}
