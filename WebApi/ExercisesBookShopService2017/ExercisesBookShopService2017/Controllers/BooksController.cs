namespace ExercisesBookShopService2017.Controllers
{
    using ExercisesBookShopService2017.Infrastructure.Filters;
    using Infrastructure.Extensions;
    
    using Microsoft.AspNetCore.Mvc;
    using Models.Books;
    using Services;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private readonly IBookService bookService;
        private readonly IAuthorService authorService;

        public BooksController(IBookService bookService, IAuthorService authorService)
        {
            this.bookService = bookService;
            this.authorService = authorService;
        }


        [HttpGet("{bookId}")]
        public async Task<IActionResult> Get(int bookId)
            => this.OkOrNotFound(await this.bookService.GetByIdAsync(bookId));

        [HttpGet]
        public async Task<IActionResult> TopBooks([FromQuery] string search = "")
           => this.OkOrNotFound(await this.bookService.GetTopBooksByTitleAscendingAsync(search));

        [HttpPost]
        [ValidateModelState]
        public async Task<IActionResult> Create([FromBody] CreateBookRequestApiModel bookModel)
        {
            if (!await this.authorService.Exist(bookModel.AuthorId))
            {
                return this.BadRequest("Author does not exists.");
            }

            var id = await this.bookService.Create(
                bookModel.Title,
                bookModel.Description,
                bookModel.Price,
                bookModel.Copies,
                bookModel.Edition,
                bookModel.AgeRestriction,
                bookModel.ReleaseDate,
                bookModel.CategoryNames,
                bookModel.AuthorId);

            return this.Ok(id);
        }

        [HttpPut("{bookId}")]
        [ValidateModelState]
        public async Task<IActionResult> EditById(int bookId, [FromBody] EditBookByIdRequestApiModel bookModel)
        {
            var success = await this.bookService.EditByIdAsync(
                bookId,
                bookModel.Title,
                bookModel.Description,
                bookModel.Price,
                bookModel.Copies,
                bookModel.Edition,
                bookModel.AgeRestriction,
                bookModel.ReleaseDate,
                bookModel.AuthorId);

            if (!success)
            {
                return this.BadRequest();
            }

            return this.Ok();
        }

        [HttpDelete("{bookId}")]
        public async Task<IActionResult> Delete(int id)
        {
            var sucess = await this.bookService.Delete(id);

            if (!sucess)
            {
                return this.BadRequest($"No book with id {id} exist.");
            }

            return this.Ok(id);
        }
    }
}
