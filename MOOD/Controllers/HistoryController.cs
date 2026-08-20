using Microsoft.AspNetCore.Mvc;

namespace MOOD.Controllers
{
    public class HistoryController : Controller
    {
        public IActionResult Index()
        {
            return View("../History/index");
        }
    }
}