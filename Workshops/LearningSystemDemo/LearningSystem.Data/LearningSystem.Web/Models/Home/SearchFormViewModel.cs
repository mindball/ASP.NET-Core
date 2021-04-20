using System.ComponentModel.DataAnnotations;

namespace LearningSystem.Web.Models.Home
{
    public class SearchFormViewModel
    {
        
        public string SearchText { get; set; }

        [Display(Name = "Search in users")]
        public bool SearchUsers { get; set; } = true;

        [Display(Name = "Search in users")]
        public bool SearchCourses { get; set; } = true;
    }
}
