namespace MyWebApp.Models
{
    public class Learner
    {
        public int LearnerID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int MajorID { get; set; }
        public Major Major { get; set; }
        public ICollection<Course> Enrollments { get; set; }
    }
}
