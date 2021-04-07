using LearningSystem.Data;
using LearningSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Services.Blog
{
    public class BlogArticleService : IBlogArticleService
    {
        private readonly LearningSystemDbContext dbContext;

        public BlogArticleService(LearningSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
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
