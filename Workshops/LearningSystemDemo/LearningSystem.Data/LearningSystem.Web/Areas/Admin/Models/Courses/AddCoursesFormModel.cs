using LearningSystem.Web.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using static LearningSystem.Data.DataConstants;

namespace LearningSystem.Web.Areas.Admin.Models.Courses
{
    public class AddCoursesFormModel : IValidatableObject
    {
        [Required]
        [MaxLength(CourseNameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(CourseDescriptionMaxLength)]
        public string Description { get; set; }

        [DataType(DataType.Date)]

        [DateTimeFromValidateTo(nameof(EndDate))]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        
        public DateTime EndDate { get; set; }

        [Required]
        [Display(Name = "Trainer")]
        public string TrainerId { get; set; }

        public IEnumerable<SelectListItem> Trainers { get; set; }


        //Validation in viewModel
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.StartDate < DateTime.UtcNow)
            {
                yield return new ValidationResult("Start date should be in the future.");
            }

            if (this.StartDate > this.EndDate)
            {
                yield return new ValidationResult("Start date should be before end date.");
            }
        }
    }
}
