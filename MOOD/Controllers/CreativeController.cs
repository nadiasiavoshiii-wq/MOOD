using Microsoft.AspNetCore.Mvc;

namespace MOOD.Controllers
{
    public class CreativeController : Controller
    {
        public IActionResult Index()
        {
            return View("../Creative/index");
        }
        public IActionResult Drawing()
        {
            return View("../Creative/Drawing");
    }
        public IActionResult MusicMaking()
        {
            return View("../Creative/MusicMaking");
        }
    }
}
