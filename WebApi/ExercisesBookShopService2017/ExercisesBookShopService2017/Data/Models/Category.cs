namespace ExercisesBookShopService2017.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        [MinLength(CategoryNameMinLeght)]
        [MaxLength(CategoryNameMaxLeght)]
        public string Name { get; set; }

        public virtual List<BooksCategories> Books { get; set; } = new List<BooksCategories>();
    }
}
