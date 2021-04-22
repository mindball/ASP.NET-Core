using AutoMapper;
using LearningSystem.Common.Mapping;
using LearningSystem.Data.Models;
using System;

namespace LearningSystem.Services.Courses.Models
{
    public class CourseListingServiceModel : CourseDetailsServiceModel, IMapFrom<Course>, IHaveCustomMapping
    {
        //public string Id { get; set; }       

        //public string Name { get; set; } 

        //public DateTime StartDate { get; set; }

        //public DateTime EndDate { get; set; }

        public string SomeCustomMappingToTest { get; set; }

        public override void ConfigureMapping(Profile mapper)
        {
            mapper.CreateMap<Course, CourseListingServiceModel>()
                .ForMember(cl => cl.SomeCustomMappingToTest, cfg =>
                    cfg.MapFrom(c => c.Description + c.Name));
        }
    }
}
