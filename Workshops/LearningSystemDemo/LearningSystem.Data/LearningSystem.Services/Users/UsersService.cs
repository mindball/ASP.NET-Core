using AutoMapper.QueryableExtensions;
using LearningSystem.Data;
using LearningSystem.Services.Users.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace LearningSystem.Services.Users
{
    public class UsersService : IUsersService
    {
        private readonly LearningSystemDbContext db;

        public UsersService(LearningSystemDbContext db)
        {
            this.db = db;
        }

        public async Task<UserProfileServiceModel> ProfileAsync(string userId)
        {      
            var userProfile =   await this.db
                      .Users
                      .Where(u => u.Id == userId)
                      .ProjectTo<UserProfileServiceModel>(new { studentId = userId })
                      .FirstOrDefaultAsync();

            return userProfile;           
        }
    }
}
