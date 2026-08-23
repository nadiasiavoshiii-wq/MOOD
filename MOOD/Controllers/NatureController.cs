using Microsoft.AspNetCore.Mvc;

namespace MOOD.Controllers
{
    public class NatureController : Controller
    {
        public IActionResult Index()
        {
            return View("../Nature/index");
        }
    }
}
