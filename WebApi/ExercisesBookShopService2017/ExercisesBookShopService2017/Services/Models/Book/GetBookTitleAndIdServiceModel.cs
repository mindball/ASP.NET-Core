namespace ExercisesBookShopService2017.Services.Models.Book
{
    using Common.Mapping;
    using Data.Models;

    public class GetBookTitleAndIdServiceModel : IMapFrom<Book>
    {
        public string Title { get; set; }

        public int BookId { get; set; }
    }
}
