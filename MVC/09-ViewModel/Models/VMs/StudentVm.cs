using System.ComponentModel.DataAnnotations;

namespace _09_ViewModel.Models.VMs
{
    public class StudentVm
    {
        // VM'lerin amacı sınıfların ıcınde olan bazı propları gorunmesını ıstediğim zaman yada birleştirmek istediğim zaman
        [Display(Name="No")]
        public int Id { get; set; }
        [Display(Name="Adı")]
        public string Name { get; set; }
        [Display(Name="Soyadı")]
        public string Surname { get; set; }
        [Display(Name="Kurs No")]
        public int CourseId { get; set; }
    }
}
