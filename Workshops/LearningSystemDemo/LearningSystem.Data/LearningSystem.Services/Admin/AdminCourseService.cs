using LearningSystem.Data;
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

        public Task CreateAsync(string name, 
            string description, 
            DateTime startDate, 
            DateTime endDate, 
            string trainerId)
        {
            throw new NotImplementedException();
        }
    }
}
