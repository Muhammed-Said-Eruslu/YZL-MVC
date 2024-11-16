using _03_MVC_WebAPP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _03_MVC_WebAPP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // Constructer Method
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        // siteurl/controllerName/ActionMethodName[id (varsa)]
        // htpp://www.abc.com/home/�ndex
        // Action Result
        public IActionResult Index() // �ndex sayfas� talep ed�ld�g�nde bu acton result cal�s�r
        {
            /*
             AppDbContext ctx = new AppDbContext();
            var  model = ctx.Product.ToList();
            return View(model);
             */
            ViewBag.Title = "Home";
            return View(); // View klosorune g�der ordan �ndex � bulur
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
