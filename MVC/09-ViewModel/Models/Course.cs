namespace _09_ViewModel.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        // bir dersin bırden fazla ogrencsı olur
        public ICollection<Student> Student { get; set; }
    }
}
