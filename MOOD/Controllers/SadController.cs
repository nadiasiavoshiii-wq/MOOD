using Microsoft.AspNetCore.Mvc;

namespace MOOD.Controllers
{
    public class SadController : Controller
    {
        public IActionResult Index()
        {
            return View("../Sad/index");
        }
    }
}
