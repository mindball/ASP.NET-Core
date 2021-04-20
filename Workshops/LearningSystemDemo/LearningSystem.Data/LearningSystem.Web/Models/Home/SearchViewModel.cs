using LearningSystem.Services.Courses.Models;
using LearningSystem.Services.Users.Models;
using System.Collections.Generic;

namespace LearningSystem.Web.Models.Home
{
    public class SearchViewModel
    {
        public IEnumerable<CourseListingServiceModel> Courses { get; set; }
            = new List<CourseListingServiceModel>();

        public IEnumerable<UserListingServiceModel> Users { get; set; }
            = new List<UserListingServiceModel>();

        public string SearchText { get; set; }
    }
}
