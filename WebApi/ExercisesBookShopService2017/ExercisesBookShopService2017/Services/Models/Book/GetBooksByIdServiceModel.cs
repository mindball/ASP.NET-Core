namespace ExercisesBookShopService2017.Services.Models.Book
{
    using Author;
    using AutoMapper;
    using Common.Mapping;
    using Data.Models;
    using System.Linq;

    public class GetBooksByIdServiceModel : GetBooksDetailsServiceModel, IMapFrom<Book>, IHaveCustomMapping
    {
        public override void ConfigureMapping(Profile mapper)
        {
            mapper.CreateMap<Book, GetBooksByIdServiceModel>()
                .ForMember(b => b.Author, cfg => cfg
                    .MapFrom(b => b.Author.FirstName + " " + b.Author.LastName))
                .ForMember(b => b.Categories, cfg => cfg
                    .MapFrom(b => b.Categories
                        .Select(c => c.Category.Name)));
        }
    }
}
