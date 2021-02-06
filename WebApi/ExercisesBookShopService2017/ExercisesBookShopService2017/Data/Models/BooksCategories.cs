namespace ExercisesBookShopService2017.Data.Models
{
    public class BooksCategories
    {
        public int BookCategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int CategoryId { get; set; }

        public virtual Book Book { get; set; }

        public int BookId { get; set; }
    }
}
