using Microsoft.AspNetCore.Mvc;

namespace NetCore_Sessions.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult History()
        {
            return View();
        }
    }
}
