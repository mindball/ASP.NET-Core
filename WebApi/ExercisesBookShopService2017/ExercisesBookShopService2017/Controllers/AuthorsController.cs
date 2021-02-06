namespace ExercisesBookShopService2017.Controllers
{
    using ExercisesBookShopService2017.Infrastructure.Extensions;
    using ExercisesBookShopService2017.Services;
    using ExercisesBookShopService2017.Services.Models.Author;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    public class AuthorsController : Controller
    {
        private readonly IAuthorService authorService;

        public AuthorsController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }

        [HttpGet("{authorId}")]
        public async Task<ActionResult<GetAuthorByIdServiceModel>> Get(int authorId)
            => await this.authorService.GetByIdAsync(authorId);

        [HttpGet("{authorId}" + "/books")]
        public async Task<IActionResult> Books(int authorId)
          => this.OkOrNotFound(await this.authorService.GetBooksAsync(authorId));
    }
}
