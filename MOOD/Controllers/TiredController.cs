using Microsoft.AspNetCore.Mvc;

namespace MOOD.Controllers
{
    public class TiredController : Controller
    {
        public IActionResult Index()
        {
            return View("../Tired/index");

        }
    }
}
