using AutoMapper.QueryableExtensions;
using LearningSystem.Data;
using LearningSystem.Services.Admin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearningSystem.Services.Admin
{
    public class AdminUserService : IAdminUserService
    {
        private readonly LearningSystemDbContext context;
        public AdminUserService(LearningSystemDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<AdminUserListingServiceModel>> AllAsync()
            => await this.context.Users
            .ProjectTo<AdminUserListingServiceModel>()
            .ToListAsync();
    }
}
