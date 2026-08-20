using Microsoft.AspNetCore.Mvc;

namespace MOOD.Controllers
{
    public class EnergeticController : Controller
    {
        public IActionResult Index()
        {
            return View("../Energetic/index");
        }
    }
}
