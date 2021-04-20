using LearningSystem.Services.Courses.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearningSystem.Services.Courses
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseListingServiceModel>> ActiveAsync();

        Task<IEnumerable<CourseListingServiceModel>> FindCoursesAsync(string searchText);

        Task<TModel> ByIdAsync<TModel>(string id) where TModel : class;

        Task<bool> StudentIsEnrolledCourseAsync(string courseId, string userId);

        Task<bool> SignUpStudentAsync(string courseId, string studentId);

        Task<bool> SignOutStudentAsync(string courseId, string studentId);
    }
}
