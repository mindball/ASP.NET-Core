using LearningSystem.Services.Blog.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Services.Blog
{
    public interface IBlogArticleService
    {
        Task<IEnumerable<BlogArticleListingServiceModel>> AllAsync(int page = 1);

        Task<BlogArticleDetailsServiceModel> GetByIdAsync(string Id);

        Task<int> TotalAsync();

        Task CreateAsync(string title, string content, string authorId);
    }
}
