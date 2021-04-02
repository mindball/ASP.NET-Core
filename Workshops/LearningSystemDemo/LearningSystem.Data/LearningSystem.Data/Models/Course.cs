using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using static LearningSystem.Data.DataConstants;

namespace LearningSystem.Data.Models
{
    public class Course
    {
        public Course()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        [MaxLength(CourseNameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(CourseDescriptionMaxLength)]
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        //public string TrainerId { get; set; }

        //public virtual User Trainer { get; set; }

        public virtual List<StudentCourse> Students { get; set; } = new List<StudentCourse>();
    }
}
