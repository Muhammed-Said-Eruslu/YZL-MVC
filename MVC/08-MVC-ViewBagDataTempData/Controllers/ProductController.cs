using Microsoft.AspNetCore.Mvc;

namespace _08_MVC_ViewBagDataTempData.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            // Conttroler To Action: ViewBag,ViewData,TempData
            // Action To Action: TempData
            TempData["Error Message"] = "Bir Hata Gerçekleşti";

            ViewBag.baslık = "Öğrenci";
            ViewData["Baslik"] = "Öğrenci";

            return RedirectToAction("Error","Product");
        }
        public IActionResult Error()
        {
            var errorMassage =  TempData["Error Message"] as string;
            //var baslık = ViewBag.baslık;
            var baslık = ViewData["Baslik"] as string;
            return Content(errorMassage);
        }
    }
}
