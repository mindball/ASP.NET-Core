using AutoMapper;
using LearningSystem.Common.Mapping;
using LearningSystem.Data.Enums;
using LearningSystem.Data.Models;
using System;
using System.Linq;

namespace LearningSystem.Services.Trainers.Models
{
    public class StudentInCourseServiceModel : IMapFrom<User>, IHaveCustomMapping
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public Grade? Grade { get; set; }

        public void ConfigureMapping(Profile mapper)
        {
            string courseId = null;
            mapper.CreateMap<User, StudentInCourseServiceModel>()
                .ForMember(st => st.Grade, cfg =>
                            cfg.MapFrom(us => us.Courses
                                        .Where(g => g.CourseId == courseId)
                                        .Select(c => c.Grade)
                                        .FirstOrDefault()));
        }
    }
}
