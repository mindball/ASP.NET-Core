using AutoMapper.QueryableExtensions;
using LearningSystem.Data;
using LearningSystem.Data.Models;
using LearningSystem.Services.Blog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using static LearningSystem.Services.ServiceConstants;

namespace LearningSystem.Services.Blog
{
    public class BlogArticleService : IBlogArticleService
    {
        private readonly LearningSystemDbContext dbContext;

        public BlogArticleService(LearningSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<BlogArticleDetailsServiceModel> GetByIdAsync(string Id)
        => await this.dbContext.Articles
            .Where(a => a.Id == Id)
            .ProjectTo<BlogArticleDetailsServiceModel>()
            .FirstOrDefaultAsync();

        public async Task<IEnumerable<BlogArticleListingServiceModel>> AllAsync(int page = 1)
            => await this.dbContext
                        .Articles
                        .OrderByDescending(a => a.PublishDate)
                        .Skip((page - 1) * BlogArticlesPageSize)
                        .Take(BlogArticlesPageSize)
                        .ProjectTo<BlogArticleListingServiceModel>()
                        .ToListAsync();

        public async Task<int> TotalAsync()
        => await this.dbContext.Articles.CountAsync();

        public async Task CreateAsync(string title, string content, string authorId)
        {
            var article = new Article
            {
                Title = title,
                Content = content,
                PublishDate = DateTime.UtcNow,
                AuthorId = authorId
            };

            this.dbContext.Add(article);

            await this.dbContext.SaveChangesAsync();
        }
    }
}
