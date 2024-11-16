using Microsoft.AspNetCore.Mvc;

namespace _07_MVC_ActionMetotlar.Controllers
{
    public class BlogController : Controller
    {
        /*
         Actionlar,uygulamadıkı bir eyleme karsılık gelen operasyonları yoneten ve ardından işlemin sonucuna gore kullanıcıya sonuc ureten metotlardır

        Action verb:
        Get: Bir kaynağın okunması veya alınması ıcın kullanılır.Orneğin web sayfasında goruntulemek
        -Post:Veri göndermek ve sunucuya kaydetmek ıcın kullanılır.Örneğin yeni bir kayıt olusturmak ıcın post kullanırım
        -Put:Bir kaynağı güncellemek için veya değiştirmek için kullanılır.Ozellıkle RestFul Apılerde daha cok kullanılır
        -Delete: Silme
        Patch: Kısmi güncelleme için kullanılır
         */
        public IActionResult Index()
        {
            // Actioan Result
            // View: Bir görünüm sayfasını temsıl eder.Html cıktısı olusturmak ıcın kullanılır
            // return View("Create");
            //return RedirectToAction("Index","Home");    Home/Index'e gider
            // Content: Belirli bir metin dondurmek ıcın kullanılır
            //return Content("Merhaba Dünya");
            // JSON: Json dosyaysı dondurur
            //var user = new { Name = "Said", Age = "19", };
            //return Json(user);
            // File:Dosya döndürür
            //return File();

            // Status Code:
            //return Ok(); // ok valid demek

            //return NotFound(); // 404 hatası dondurur

            //return BadRequest(); // 400 hatası 

           return View();
        }
        //public IActionResult Creata()
        //{

        //}
    }
}
