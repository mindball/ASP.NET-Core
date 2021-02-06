namespace ExercisesBookShopService2017.Services.Models.Author
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;

    using ExercisesBookShopService2017.Common.Mapping;
    using ExercisesBookShopService2017.Data.Models;

    public class GetBooksDetailsServiceModel : IMapFrom<Book>, IHaveCustomMapping
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public int Copies { get; set; }

        public string EditionType { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public int? AgeRestriction { get; set; }

        public Author Author { get; set; }

        public List<string> Categories { get; set; } = new List<string>();

        public virtual void ConfigureMapping(Profile mapper)
        {
            mapper.CreateMap<Book, GetBooksDetailsServiceModel>()
                .ForMember(b => b.Author, cfg => cfg
                    .MapFrom(b => b.Author.FirstName + " " + b.Author.LastName))
                .ForMember(b => b.Categories, cfg => cfg
                    .MapFrom(b => b.Categories
                        .Select(c => c.Category.Name)));
        }
    }
}
