using AutoMapper;
using LearningSystem.Common.Mapping;
using LearningSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LearningSystem.Services.Users.Models
{
    public class UserProfileServiceModel : IMapFrom<User>, IHaveCustomMapping
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public string Name { get; set; }

        public DateTime Birthdate { get; set; }

        public IEnumerable<UserProfileCourseServiceModel> Courses { get; set; }       


        public void ConfigureMapping(Profile mapper)
                => mapper
                        .CreateMap<User, UserProfileServiceModel>()
                        .ForMember(u => u.Courses,
                                cfg => cfg.MapFrom(s =>
                                s.Courses.Where(c => c.StudentId == s.Id).Select(cs => cs.Course)));
    }
}