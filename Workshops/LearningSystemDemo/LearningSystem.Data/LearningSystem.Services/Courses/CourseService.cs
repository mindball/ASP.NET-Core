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

        public async Task<TModel> ByIdAsync<TModel>(string id) where TModel : class
            => await this.dbContext
                .Courses
                .Where(c => c.Id == id)
                .ProjectTo<TModel>()
                .FirstOrDefaultAsync();

        public async Task<bool> StudentIsEnrolledCourseAsync(string courseId, string userId)
            => await this.dbContext
                .StudentsCourses
                .AnyAsync(c => c.CourseId == courseId && c.StudentId == userId);
    }
}
