using _06_MVC_TagHalper.Models;
using Microsoft.AspNetCore.Mvc;

namespace _06_MVC_TagHalper.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(Product product)
        {
            //Product product = new Product()
            //{
            //    Name = "Laptop",
            //    Password = "password",
            //    Price = 15000,
            //    Email = "saideruslu0gmail.com"
            //};
            // ViewBag.ProcutName = model.Name;
            // ViewData ["test"] = "";
            // TempData ["test"] = "";
            return View(product); // View'a model nesnesini gönderiyorum
        }
       public IActionResult Create()
        {
            return View();
        }
    }
}
