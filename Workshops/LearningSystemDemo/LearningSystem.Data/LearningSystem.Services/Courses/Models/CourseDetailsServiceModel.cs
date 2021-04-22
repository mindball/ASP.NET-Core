using AutoMapper;
using LearningSystem.Common.Mapping;
using LearningSystem.Data.Models;
using System;

namespace LearningSystem.Services.Courses.Models
{
    public class CourseDetailsServiceModel : IMapFrom<Course>, IHaveCustomMapping
    {
        public string Id { get; set; }
              
        public string Name { get; set; }
                
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Trainer { get; set; }

        public int  Students { get; set; }

        public  void ConfigureMapping(Profile mapper)
        {
            mapper.CreateMap<Course, CourseDetailsServiceModel>()
                 .ForMember(c => c.Trainer, cfg => cfg.MapFrom(c => c.Trainer.Name))
                 .ForMember(c => c.Students, cfg => cfg.MapFrom(c => c.Students.Count));
        }

        //public virtual void ConfigureMapping(Profile mapper)
        //{
        //    mapper.CreateMap<Course, CourseDetailsServiceModel>()
        //         .ForMember(c => c.Trainer, cfg => cfg.MapFrom(c => c.Trainer.Name))
        //         .ForMember(c => c.Students, cfg => cfg.MapFrom(c => c.Students.Count));
        //}
    }
}
