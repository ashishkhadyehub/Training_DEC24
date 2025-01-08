using Microsoft.AspNetCore.Mvc;

namespace LA.UI.Controllers
{
    public class ConceptController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.Message = "Hello Students";

            //ViewData["Message"] = "Message form Viewdata";
            TempData["Message"] = "Message form Tempdate";
            return View();
        }

        public IActionResult NextPage()
        {
            string message = TempData["Message"].ToString();
            return View("NextPage", message);
        }
    }
}
