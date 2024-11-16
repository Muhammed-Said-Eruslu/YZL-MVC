using _04_MVC_FirstWebPage.Models;
using Microsoft.AspNetCore.Mvc;

namespace _04_MVC_FirstWebPage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // product ısmınde bır model olustur ıcıne verı ekle ve view da goster
            Product product = new Product()
            {
                Id = 1,
                Name = "Test",
                Price = 400
            };

            return View(product);
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
