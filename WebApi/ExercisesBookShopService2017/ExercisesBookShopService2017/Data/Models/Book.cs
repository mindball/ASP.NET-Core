namespace ExercisesBookShopService2017.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Book
    {
        public int BookId { get; set; }

        [Required]
        [MinLength(TitleMinLength)]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MinLength(DescriptionMinLength)]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        [Range(PriceMinLength, PriceMaxLength)]
        public double Price { get; set; }

        [Required]
        [Range(CopiesMinLegth, CopiesMaxLength)]
        public int Copies { get; set; }

        [Required]
        [MinLength(EditionMinLength)]
        [MaxLength(EditionMaxLength)]
        public string EditionType { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int? AgeRestriction { get; set; }

        public virtual Author Author { get; set; }

        public int AuthorId { get; set; }

        public virtual List<BooksCategories> Categories { get; set; } = new List<BooksCategories>();
    }
}
