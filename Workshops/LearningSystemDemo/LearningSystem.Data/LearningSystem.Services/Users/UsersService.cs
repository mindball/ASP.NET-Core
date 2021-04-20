using AutoMapper.QueryableExtensions;
using LearningSystem.Data;
using LearningSystem.Services.Users.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

        public async Task<IEnumerable<UserListingServiceModel>> FindUsersAsync(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                throw new ArgumentException("search text is empty");
            }

            var users = await this.db.Users
                .OrderBy(c => c.UserName)
                .Where(c => c.Name.ToLower().Contains(searchText.ToLower()))
                .ProjectTo<UserListingServiceModel>()
                .ToListAsync();

            return users;
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
