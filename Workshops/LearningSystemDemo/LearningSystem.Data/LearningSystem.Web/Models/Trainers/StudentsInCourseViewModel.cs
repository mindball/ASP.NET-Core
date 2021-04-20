using LearningSystem.Services.Courses.Models;
using LearningSystem.Services.Trainers.Models;
using System.Collections.Generic;

namespace LearningSystem.Web.Models.Trainers
{
    public class StudentsInCourseViewModel
    {
        public IEnumerable<StudentInCourseServiceModel> Students { get; set; }

        public CourseListingServiceModel Course { get; set; }
    }
}
