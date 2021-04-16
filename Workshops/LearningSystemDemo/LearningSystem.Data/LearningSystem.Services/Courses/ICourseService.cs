using LearningSystem.Services.Courses.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearningSystem.Services.Courses
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseListingServiceModel>> ActiveAsync();

        Task<TModel> ByIdAsync<TModel>(string id) where TModel : class;

        Task<bool> StudentIsEnrolledCourseAsync(string courseId, string userId);

        Task<bool> SignUpStudentAsync(string courseId, string studentId);
    }
}
