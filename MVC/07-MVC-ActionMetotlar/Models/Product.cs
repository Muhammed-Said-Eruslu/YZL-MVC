using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Drawing2D;

namespace _07_MVC_ActionMetotlar.Models
{
    public class Product
    {
        [Required]
        [DisplayName("No")] // kullanıcıya gozukecek olan yer
        public int Id { get; set; }
        [Required]
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }

        [DisplayName("Stok")]
        [Range(minimum:0,maximum:1000,ErrorMessage ="Stok Sayısı 0-1000 Arasında Olmalıdır")]
        
        public int Stok { get; set; }
        [Required(ErrorMessage = "{0} Boş Geçilemez")] // zorunlu
        [DisplayName("Fiyat")]
        public double Price {  get; set; }
      



        [DisplayName("Tarih")]
        public DateTime? Date { get; set; }
    }
}
