using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NetCore_Sessions.Models;

namespace NetCore_Sessions.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //int a = 90;
            //return View(a);

            //string name = "ABC";
            //return View("Index",name);

            Students student = new Students();
            student.Id = 1;
            student.Name = "Shri";
            student.City = "Kolhapur";

            return View(student);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
