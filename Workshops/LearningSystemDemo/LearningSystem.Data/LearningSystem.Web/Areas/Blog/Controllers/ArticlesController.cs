using LearningSystem.Data.Models;
using LearningSystem.Services.Blog;
using LearningSystem.Services.HTML;
using LearningSystem.Web.Areas.Blog.Models;
using LearningSystem.Web.Validation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
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
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
            => this.View();


        [HttpPost]
        [ValidateModelState]
        public async Task<IActionResult> Create(AddArticleFormModel articleModel)
        {
            articleModel.Content = this.htmlService.Sanitize(articleModel.Content);

            var userId = this.userManager.GetUserId(User);
            await this.blogArticleService.CreateAsync(articleModel.Title, articleModel.Content, userId);

            return RedirectToAction(nameof(Index));
        }
    }
}
