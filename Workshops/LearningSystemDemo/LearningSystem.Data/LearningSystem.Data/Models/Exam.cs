using System.ComponentModel.DataAnnotations;

namespace LearningSystem.Data.Models
{
    public class Exam
    {
        //Look up readme.md
        public string StudentId { get; set; }

        public virtual User Student { get; set; }

        public string CourseId { get; set; }

        public virtual Course Course { get; set; }

        [MaxLength(DataConstants.CourseExamSubmissionFileLength)]
        public byte[] ExamSubmission { get; set; }
    }
}
