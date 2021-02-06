namespace ExercisesBookShopService2017.Services.Models.Author
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;

    using ExercisesBookShopService2017.Common.Mapping;
    using ExercisesBookShopService2017.Data.Models;

    public class GetAuthorByIdServiceModel : IMapFrom<Author>, IHaveCustomMapping
    {
        public int AuthorId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IEnumerable<string> BookTitles { get; set; } = new List<string>();

        public void ConfigureMapping(Profile mapper)
        {
            mapper.CreateMap<Author, GetAuthorByIdServiceModel>()
                .ForMember(a => a.BookTitles, cfg => cfg
                    .MapFrom(a => a.Books
                        .Select(b => b.Title)));
        }
    }
}
