using LearningSystem.Data.Models;
using LearningSystem.Services.Blog;
using LearningSystem.Services.HTML;
using LearningSystem.Web.Areas.Blog.Models;
using LearningSystem.Web.Infrastructure.Extensions;
using LearningSystem.Web.Validation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LearningSystem.Web.Areas.Blog.Controllers
{
    [Area("Blog")]
    public class ArticlesController : Controller
    {
        private readonly IBlogArticleService blogArticleService;
        private readonly UserManager<User> userManager;
        private readonly IHtmlService htmlService;

        public ArticlesController(IBlogArticleService blogArticleService,
            UserManager<User> userManager,
            IHtmlService htmlService)
        {
            this.blogArticleService = blogArticleService;
            this.userManager = userManager;
            this.htmlService = htmlService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index(int page = 1)
            =>  View(new BlogArticleListingViewModel 
                    { 
                        Articles = await this.blogArticleService.All(page),
                        TotalArticles = await this.blogArticleService.TotalAsync(),
                        CurrentPage = page
            });

        [AllowAnonymous]
        public async Task<IActionResult> Details(string id)
            => this.ViewOrNotFound(await this.blogArticleService.GetById(id));

        public IActionResult Create()
            => this.View();

        [HttpPost]
        [ValidateModelState]
        public async Task<IActionResult> Create(AddBlogArticleFormModel articleModel)
        {
            articleModel.Content = this.htmlService.Sanitize(articleModel.Content);

            var userId = this.userManager.GetUserId(User);
            await this.blogArticleService.CreateAsync(articleModel.Title, articleModel.Content, userId);

            return RedirectToAction(nameof(Index));
        }
    }
}
