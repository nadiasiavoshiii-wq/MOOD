using Microsoft.AspNetCore.Mvc;

namespace MOOD.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View("../Message/index");
        }
    }
}
