using LearningSystem.Data.Enums;
using LearningSystem.Services.Courses.Models;
using LearningSystem.Services.Trainers.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearningSystem.Services.Trainers
{
    public interface ITrainersService
    {
        Task<IEnumerable<CourseListingServiceModel>> GetCoursesAsync(string treinerId);

        Task<bool> IsTrainerAsync(string courseId, string trainerId);

        Task<IEnumerable<StudentInCourseServiceModel>> StudentsInCourseAsync(string courseId);

        Task<bool> AddGradeAsync(string courseId, string studentId, Grade grade);

        Task<byte[]> GetExamSubmissionAsync(string courseId, string studentId);

        Task<StudentInCourseNameServiceModel> StudentInCourseNamesAsync(string courseId, string studentId);
    }
}
