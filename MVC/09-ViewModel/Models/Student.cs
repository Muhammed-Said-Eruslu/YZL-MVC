using System.Reflection.Metadata.Ecma335;

namespace _09_ViewModel.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
        public int CourseId { get; set; } // Bir öğrencinini bir kursu var 
        public Course Course { get; set; }
    }
}
