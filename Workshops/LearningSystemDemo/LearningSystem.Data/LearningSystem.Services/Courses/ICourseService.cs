using LearningSystem.Services.Courses.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearningSystem.Services.Courses
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseListingServiceModel>> ActiveAsync();

        Task<TModel> ByIdAsync<TModel>(string id) where TModel : class;       
    }
}
