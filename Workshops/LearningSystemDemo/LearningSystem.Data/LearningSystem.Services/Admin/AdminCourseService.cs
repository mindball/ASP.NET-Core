using LearningSystem.Data;
using LearningSystem.Data.Models;
using System;
using System.Threading.Tasks;

namespace LearningSystem.Services.Admin
{
    public class AdminCourseService : IAdminCourseService
    {
        private readonly LearningSystemDbContext dbContext;
        public AdminCourseService(LearningSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task CreateAsync(string name, 
            string description, 
            DateTime startDate, 
            DateTime endDate, 
            string trainerId)
        {
            var newCourse = new Course
            {
                Name = name,
                Description = description,
                StartDate = startDate,
                EndDate = endDate,
                TrainerId = trainerId
            };

            this.dbContext.Add(newCourse);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
