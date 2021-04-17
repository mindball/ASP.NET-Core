using AutoMapper;
using LearningSystem.Common.Mapping;
using LearningSystem.Data.Models;
using LearningSystem.Data.Models.Enums;
using System.Linq;

namespace LearningSystem.Services.Users.Models
{
    public class UserProfileCourseServiceModel : IMapFrom<Course>, IHaveCustomMapping
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public Grade? Grade { get; set; }

        public void ConfigureMapping(Profile mapper)
        {
            string studentId = null;
            mapper
                .CreateMap<Course, UserProfileCourseServiceModel>()
                .ForMember(c => c.Grade, cfg => cfg
                        .MapFrom(g => g.Students
                        .Where(s => s.StudentId == studentId)
                        .Select(v => v.Grade)
                        .FirstOrDefault()));                        
        }
    }
}
