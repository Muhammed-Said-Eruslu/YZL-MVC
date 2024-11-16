namespace _09_ViewModel.Models.VMs
{
    public class StudentCreateVM
    {
        public int CourseId { get; set; }
        public StudentVm Student { get; set; }
        public List<Course> Course { get; set; }
    }
}
