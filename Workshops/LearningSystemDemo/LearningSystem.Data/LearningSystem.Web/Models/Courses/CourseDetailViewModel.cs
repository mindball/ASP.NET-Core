using LearningSystem.Services.Courses.Models;

namespace LearningSystem.Web.Models.Courses
{
    public class CourseDetailViewModel
    {
        public CourseDetailsServiceModel Course { get; set; }

        public bool UserIsEnrolledCourse { get; set; }
    }
}
