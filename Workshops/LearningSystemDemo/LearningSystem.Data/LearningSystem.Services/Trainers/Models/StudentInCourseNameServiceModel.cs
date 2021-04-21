using AutoMapper;
using LearningSystem.Common.Mapping;
using LearningSystem.Data.Models;
using System.Linq;

namespace LearningSystem.Services.Trainers.Models
{
    public class StudentInCourseNameServiceModel : IMapFrom<User>, IHaveCustomMapping
    {
        public string UserName { get; set; }

        public string  CourseName { get; set; }

        public void ConfigureMapping(Profile mapper)
        {
            string courseId = null;
            mapper.CreateMap<User, StudentInCourseNameServiceModel>()
                .ForMember(s => s.CourseName, cfg =>
                    cfg.MapFrom(c => c.Courses
                            .Where(sc => sc.CourseId == courseId)
                            .Select(c => c.Course.Name)
                            .FirstOrDefault()));
        }
    }
}
