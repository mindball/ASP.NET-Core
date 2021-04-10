using LearningSystem.Common.Mapping;
using LearningSystem.Data.Models;
using System;

namespace LearningSystem.Services.Courses.Models
{
    public class CourseListingServiceModel : IMapFrom<Course>
    {
        public string Id { get; set; }       
        
        public string Name { get; set; }
        
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
