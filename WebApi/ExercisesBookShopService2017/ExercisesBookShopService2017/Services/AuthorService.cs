namespace ExercisesBookShopService2017.Services
{
    using AutoMapper.QueryableExtensions;
    using Data;
    using Data.Models;
    using ExercisesBookShopService2017.Services.Models.Author;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class AuthorService : IAuthorService
    {
        private readonly BookShopDbContext db;

        public AuthorService(BookShopDbContext db)
        {
            this.db = db;
        }

        public async Task CreateAsync(string firstName, string lastName)
        {
            var haveExistAuthor = await this.db.Authors
                .AnyAsync(a => a.FirstName == firstName && a.LastName == lastName);
            if(haveExistAuthor)
            {
                throw new ArgumentException("Author already exists");
            }

            await this.db.Authors.AddAsync(new Author
            {
                FirstName = firstName,
                LastName = lastName
            });

            await this.db.SaveChangesAsync();
        }

        public async Task<bool> Exist(int authorId)
            => await this.db.Authors.AnyAsync(a => a.AuthorId == authorId);

        public async Task<IEnumerable<GetBooksDetailsServiceModel>> GetBooksAsync(int authorId)
        {
            var books = await this.db.Books
                                .Where(b => b.AuthorId == authorId)
                                .ProjectTo<GetBooksDetailsServiceModel>()
                                .ToListAsync();

            if(books.Count == 0)
            {
                return null;
            }

            return books;
        }

        public async Task<GetAuthorByIdServiceModel> GetByIdAsync(int authorId)
            => await this.db.Authors.Where(a => a.AuthorId == authorId)
                                .ProjectTo<GetAuthorByIdServiceModel>()
                                .FirstOrDefaultAsync();
    }
}
