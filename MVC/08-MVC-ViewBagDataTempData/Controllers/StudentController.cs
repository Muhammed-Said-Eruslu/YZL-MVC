using Microsoft.AspNetCore.Mvc;

namespace _08_MVC_ViewBagDataTempData.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            // ViewBag: Verileri controllerden view a iletmek ıcın kullanılan dynamıc bır nesnedir
            // Veriler okumak için veya null kontrolü yapmak için typeCast'e ihtiyac yoktur
            // eğer model varsa razor view olusturulur yoksa empty view olusturulur
            ViewBag.baslık = "Öğrenciler";
            List<string> students = new List<string>()
            {
                "Said",
                "Muhammed",
                "Zafer",
                "Eruslu"
            };
            ViewBag.students = students;

            //ViewData:Verileri Controllerdan view'a iletmek için kullanılan Dictonary(key-value) bir nesnedir
            // Key-Value çifti biçiminde data iletilir
            // Veriler okumak için veya null kontrolü yapmak için typeCast'e ihtiyac vardır

            ViewData["Başlık"] = "Öğrenciler"; // baslık dediğin zaman öğrenciler gelir değeri yani

            ViewData["students"] = students;

            // TempData: Verilerin aynı Controller'dan veya farklı Controller'dan bir metotdan diğerine taşımak için kullanılır
            // Verileri HTTP isteği sürecince tutar yanı oturum acık kaldığı sürece
            // Veriler okumak için veya null kontrolü yapmak için typeCast'e ihtiyac vardır
            TempData["Baslik"] = "Öğrenciler";

            TempData["students"] = students;

            return View();
        }
    }
}
/*
Controllers: HomeController,StudentController,ProductController,CategoryControl,SupplierControler
- Action Metotlar,Create,Update,Delete,Insert(HttpGet/HttpPost),
-  List,ById,Details (HttpGet)

Models: Altında Entityler,DTO(Data Transfer Object),VM

Views:
-Home
    -Index
-Product
    -Create.cshtml
    -Update.cshtml
    -Index.cshtml(List)
    -Details.html
 
 */
