using AutoMapper.QueryableExtensions;
using LearningSystem.Data;
using LearningSystem.Services.Users.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Services.Users
{
    public class UsersServices : IUsersService
    {
        private readonly LearningSystemDbContext db;

        public UsersServices(LearningSystemDbContext db)
        {
            this.db = db;
        }

        public async Task<UserProfileServiceModel> ProfileAsync(string userId)
            => await this.db
                    .Users
                    .Where(u => u.Id == userId)
                    .ProjectTo<UserProfileServiceModel>(new { studentId = userId })
                    .FirstOrDefaultAsync();
    }
}
