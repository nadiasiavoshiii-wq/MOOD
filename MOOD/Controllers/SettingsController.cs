using Microsoft.AspNetCore.Mvc;

namespace MOOD.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View("../Settings/index");
        }
    }
}
