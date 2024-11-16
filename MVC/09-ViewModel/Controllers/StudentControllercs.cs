using _09_ViewModel.Models;
using _09_ViewModel.Models.VMs;
using Microsoft.AspNetCore.Mvc;

namespace _09_ViewModel.Controllers
{
    public class StudentControllercs : Controller
    {
        private static List<Student> _students;
        public StudentControllercs()
        {
            if(_students is null) // students lıstesı null oldugu zaman ekleme yapar
            {
                _students = new List<Student>()
            {
               new Student() {StudentId = 1,FirstName = "Said",LastName="Eruslu",CreatedDate = DateTime.Now,Status = true,CourseId = 1, Course = new Course{CourseId = 1, CourseName ="YZL-5101" } },
               new Student() {StudentId = 2,FirstName = "Batuhan",LastName="Baltacı",CreatedDate = DateTime.Now,Status = true,CourseId = 2, Course = new Course{CourseId = 2, CourseName ="YZL-5101" } },
               new Student() {StudentId = 3,FirstName = "Zafer",LastName="Dörter",CreatedDate = DateTime.Now,Status = true, CourseId = 1, Course = new Course{CourseId = 1, CourseName ="YZL-5101" } },
            };
            }
        }
        public IActionResult Index()
        {
            var studentVM = _students.Select(x => new StudentVm() { Id = x.StudentId, Name = x.FirstName, Surname = x.LastName, CourseId = x.CourseId }); //StudentVm'in icini dolduruyoruz kullanıcıya gosterielecek olan sınıf
            return View(studentVM);
        }
        [HttpGet]
        public IActionResult Create()
        {
            StudentCreateVM vm = new StudentCreateVM();
            vm.Course = GetCourses();
            return View(vm);
        }

        private List<Course> GetCourses()
        {
            return new List<Course>()
            {
                new Course{CourseId = 1 , CourseName = "YZL-5101"},
                new Course{CourseId = 2 , CourseName = "YZL-5201"},
                new Course{CourseId = 3 , CourseName = "YZL-5301"}
            };
        }

        [HttpPost]
        public IActionResult Create(StudentCreateVM models)
        {
            Student student = new Student()
            {
                CourseId = models.Student.CourseId,
                FirstName = models.Student.Name,
                LastName = models.Student.Surname,
                CreatedDate = DateTime.Now,
                Status = true,
                StudentId = 4
            };

            _students.Add(student);
            return RedirectToAction("Index");
        }
    }
}
