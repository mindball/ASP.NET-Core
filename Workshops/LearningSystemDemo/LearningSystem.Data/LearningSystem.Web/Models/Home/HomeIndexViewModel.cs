using LearningSystem.Services.Courses.Models;
using System.Collections.Generic;

namespace LearningSystem.Web.Models.Home
{
    public class HomeIndexViewModel : SearchFormViewModel
    {
        public IEnumerable<CourseListingServiceModel> Courses { get; set; }
    }
}
