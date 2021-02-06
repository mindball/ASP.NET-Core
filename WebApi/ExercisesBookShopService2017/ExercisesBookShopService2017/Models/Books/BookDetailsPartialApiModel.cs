namespace ExercisesBookShopService2017.Models.Books
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static Data.DataConstants;

    public class BookDetailsPartialApiModel
    {
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
        public string Edition { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public int? AgeRestriction { get; set; }

        [Range(1, int.MaxValue)]
        public int AuthorId { get; set; }
    }
}
