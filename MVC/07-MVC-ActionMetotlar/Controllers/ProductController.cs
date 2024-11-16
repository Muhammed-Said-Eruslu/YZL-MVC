using _07_MVC_ActionMetotlar.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace _07_MVC_ActionMetotlar.Controllers
{
    public class ProductController : Controller
    {
        private static IList<Product> _products; // statik oldugu ıcın uygulama boyunca aynı lıste kullanılır
        public ProductController()
        {
            if (_products == null) // liste nulsa asağıdakı değerleri ekler
            {
                _products = new List<Product>()
                {
                    new Product { Id = 1, Name = "Kalem-1", Stok = 100, Price = 120, Date = DateTime.Now },
                    new Product { Id = 2, Name = "Kalem-2", Stok = 50, Price = 200, Date = DateTime.Now },
                    new Product { Id = 3, Name = "Kalem-3", Stok = 80, Price = 100, Date = DateTime.Now },
                    new Product { Id = 4, Name = "Kalem-4", Stok = 6, Price = 300, Date = DateTime.Now },
                    new Product { Id = 5, Name = "Kalem-5", Stok = 200, Price = 60l, Date = DateTime.Now }
                };
            }
        }
        // Html Methods: Get,Post,Delete,Push
        [HttpGet] // bir metodun ustunde bır sey yazmıyorsa HttpGet yazıyordur default halınde vardır
        public IActionResult Index() // Index sayfası görüntülendiğinde lısteleme yapar
        {
            return View(_products); // products lıstesını verdim
        }
        // Product/Create
        [HttpGet]
        public IActionResult Create() // kullanıcıya boş bir form gösterir
        {
            return View();
        }
        // Create Formu Submit oldgunda bu actıona dusecek
        [HttpPost] // formu doldurduktan sonra yakalancak metot
        public IActionResult Create(Product model)
        {
            if (ModelState.IsValid) // model ılk basta geldıgınde gelen alanların dolu olup olmadıgını kontrol ederim
            {
                _products.Add(model); // Product Listesıne ekleme yapıyoruz
                return RedirectToAction("Index"); // ekleme işlemi yaptıktan sonra ındex sayfasına yonlendır
            }
            else
            {
                return View(model); // Validasyon dogru değilse Create sayfasına tekrar dön ama doldurulan verileri de ekranda göster
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Product model = _products.FirstOrDefault(x => x.Id == id);
            return View(model); // bulunann ıd yı edıt sayfasına gondermek ıcın kullanılur Edit/1 istediği yapılırsa ıd değeri 1 olur
        }
        [HttpPost]
        public IActionResult Edit(Product model)
        {
            if (ModelState.IsValid)
            {
                Product value = _products.FirstOrDefault(x => x.Id == model.Id); // yenı bır product sınıfı olusturup _products lıstesındekı paramtereden gelen ılk ve ıd sı esıt olanı getırdi yanı lıstenın ıcındekı ıd parametrden gelen değere eşit olanları getirdi
                value.Name = model.Name;
                value.Stok = model.Stok;
                value.Price = model.Price;
                RedirectToAction("Index");
            }
            else
            {
                return View(model); // hatalı işlem yaptıysa sayfayı ıslemlerle bırlıkte dondurur
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Product product = _products.FirstOrDefault(x => x.Id == id); // parametreden gelen ıd yı bulur ve o ıd ye sahıp urunu lısteler
            return View(product);
        }
        [HttpPost]
        public IActionResult Delete(Product model)
        {
            
            Product product = _products.FirstOrDefault(x => x.Id == model.Id); // bu lıstede sılmek ıstediği ıd bulunuyor mu guvenlık ııcn kullanıcı manupıle edebilir
            if (product != null)
            {
                _products.Remove(product);
                return RedirectToAction("Index");
            }
            else
            {
                return Content("Hatalı Id");
            }
        }
    }
}
