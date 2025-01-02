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

            //Students student = new Students();
            //student.Id = 1;
            //student.Name = "Shri";
            //student.City = "Kolhapur";
            //return View(student);

            //Generic collection
            
            List<Students> students = new List<Students>();
            students.Add(new Students { Id=1, Name="Shree",City="Mumbai"});
            students.Add(new Students { Id=2,Name="ABC",City="Delhi"});
            students.Add(new Students { Id=3,Name="PQR",City="Jaipur"});
            students.Add(new Students { Id=3,Name="XYZ",City="Pune"});

            return View(students);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ClientInfo()
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
