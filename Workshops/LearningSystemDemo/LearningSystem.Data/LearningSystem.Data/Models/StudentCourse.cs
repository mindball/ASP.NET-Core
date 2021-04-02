namespace LearningSystem.Data.Models
{
    public class StudentCourse
    {
        public string StudentId { get; set; }

        public virtual User Student { get; set; }

        public string CourseId { get; set; }

        public virtual Course Course { get; set; }       
    }
}
