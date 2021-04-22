using AutoMapper;
using LearningSystem.Common.Mapping;
using LearningSystem.Data.Models;
using System;

namespace LearningSystem.Services.Courses.Models
{
    //Re use code with override Custommapping
    //public class CourseListingServiceModel : CourseDetailsServiceModel, IMapFrom<Course>, IHaveCustomMapping
    public class CourseListingServiceModel :  IMapFrom<Course>//, IHaveCustomMapping
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        //Re use code with override Custommapping
        public string SomeCustomMappingToTest { get; set; }

        //Re use code with override Custommapping
        //public override void ConfigureMapping(Profile mapper)
        //{
        //    mapper.CreateMap<Course, CourseListingServiceModel>()
        //        .ForMember(cl => cl.SomeCustomMappingToTest, cfg =>
        //            cfg.MapFrom(c => c.Description + c.Name));
        //}
    }
}
