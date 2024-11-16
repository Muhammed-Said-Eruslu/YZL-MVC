using Microsoft.AspNetCore.Mvc;

namespace _08_MVC_ViewBagDataTempData.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
     
        }
        public IActionResult Create(IFormCollection form)
        {
            // View To Action
            string name = form["Name"];
            string email = form["Email"];
            return Content($"Adı {name} Email {email}");
        }
    }
}
