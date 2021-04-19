using LearningSystem.Data.Enums;

namespace LearningSystem.Data.Models
{
    public class StudentCourse
    {
        public string StudentId { get; set; }

        public virtual User Student { get; set; }

        public string CourseId { get; set; }

        public virtual Course Course { get; set; }

        //when users register Grade must be null
        public Grade? Grade { get; set; }
    }
}
