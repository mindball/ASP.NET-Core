using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using static LearningSystem.Data.DataConstants;

namespace LearningSystem.Data.Models
{
    public class User : IdentityUser
    {
        [Required]
        [MinLength(UserNameMinLength)]
        [MaxLength(UserNameMaxLength)]
        public string Name { get; set; }

        public DateTime Birthdate { get; set; }

        public virtual List<Article> Articles { get; set; } = new List<Article>();

        //public virtual List<Course> Trainings { get; set; } = new List<Course>();

        public List<StudentCourse> Course { get; set; } = new List<StudentCourse>();
    }
}
