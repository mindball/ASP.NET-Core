namespace ExercisesBookShopService2017.Services
{
    using AutoMapper.QueryableExtensions;
    using Data;
    using Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Models.Book;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class BookService : IBookService
    {
        private readonly BookShopDbContext db;

        public BookService(BookShopDbContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<GetBooksByIdServiceModel>> GetByIdAsync(int id)
            => await this.db.Books
                    .Where(b => b.BookId == id)
                    .ProjectTo<GetBooksByIdServiceModel>()
                    .ToListAsync();

        public async Task<IEnumerable<GetBookTitleAndIdServiceModel>> GetTopBooksByTitleAscendingAsync(string search)
            => await this.db.Books
                    .Where(b => b.Description.ToLower()
                                    .Contains(search.ToLower()) ||
                                b.Title.ToLower()
                                    .Contains(search.ToLower()))
                    .OrderBy(t => t.Title)
                    .Take(10)
                    .ProjectTo<GetBookTitleAndIdServiceModel>()
                    .ToListAsync();

        public async Task<int> Create(string title, string description, double price, int copies, string edition, int? ageRestriction,
            DateTime releaseDate, string categoryNames, int authorId)
        {
            var splitCategoryNames = categoryNames
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToHashSet();

            var existingCategories = await this.db
                .Categories
                .Where(ct => splitCategoryNames
                    .Contains(ct.Name))
                .ToListAsync();

            var allCategories = new List<Category>(existingCategories);

            this.CreateAndAddNonExistingCategories(splitCategoryNames, existingCategories, allCategories);

            await this.db.SaveChangesAsync();

            var book = new Book
            {
                Title = title,
                Description = description,
                Price = price,
                Copies = copies,
                EditionType = edition,
                AgeRestriction = ageRestriction,
                ReleaseDate = releaseDate,
                AuthorId = authorId
            };

            allCategories.ForEach(c => book.Categories.Add(new BooksCategories
            {
                CategoryId = c.CategoryId
            }));

            await this.db.Books.AddAsync(book);
            await this.db.SaveChangesAsync();

            return book.BookId;
        }

        public async Task<bool> EditByIdAsync(int id, string title, string description, double price, int copies, string edition,
            int? ageRestriction, DateTime releaseDate, int authorId)
        {
            var book = await this.db.Books
                .FirstOrDefaultAsync(b => b.BookId == id);

            if (book == null)
            {
                return false;
            }

            book.Title = title;
            book.Description = description;
            book.Price = price;
            book.Copies = copies;
            book.EditionType = edition;
            book.AgeRestriction = ageRestriction;
            book.ReleaseDate = releaseDate;
            book.AuthorId = authorId;

            await this.db.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var book = await this.db.Books
                .FirstOrDefaultAsync(b => b.BookId == id);

            if (book == null)
            {
                return false;
            }

            this.db.Remove(book);
            await this.db.SaveChangesAsync();

            return true;
        }

        private void CreateAndAddNonExistingCategories(HashSet<string> splitCategoryNames, List<Category> existingCategories,
            List<Category> allCategories)
        {
            foreach (var categoryName in splitCategoryNames)
            {
                if (existingCategories.All(c => c.Name != categoryName))
                {
                    var category = new Category
                    {
                        Name = categoryName
                    };

                    allCategories.Add(category);
                    this.db.Categories.Add(category);
                }
            }
        }
    }
}
