using Microsoft.AspNetCore.Mvc;

namespace MOOD.Controllers
{
    public class MusicController : Controller
    {
        public IActionResult Index()
        {
            return View("../Music/index");
        }
    }
}
