using LearningSystem.Services.Courses.Models;
using System.Collections.Generic;

namespace LearningSystem.Web.Models.Home
{
    public class HomeIndexViewModel
    {
        public IEnumerable<CourseListingServiceModel> Courses { get; set; }
    }
}
