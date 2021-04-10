using AutoMapper.QueryableExtensions;
using LearningSystem.Data;
using LearningSystem.Services.Courses.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningSystem.Services.Courses
{
    public class CourseService : ICourseService
    {
        private readonly LearningSystemDbContext dbContext;

        public CourseService(LearningSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IEnumerable<CourseListingServiceModel>> ActiveAsync()
        {

            var date = DateTime.UtcNow;
            var courseData = await this.dbContext.Courses
                  .Select(c => c.StartDate).FirstAsync();


            bool com = date > courseData;

            var result = await this.dbContext.Courses                  
                  .Where(c => c.StartDate >= date)
                  .ProjectTo<CourseListingServiceModel>()
                  .ToListAsync();

            return result;
        }
    }
}
