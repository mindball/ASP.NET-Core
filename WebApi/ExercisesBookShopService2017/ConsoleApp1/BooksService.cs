using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BookService : IBookService
    {
        public Task<int> Create(string title, string description, double price, int copies, string edition, int? ageRestriction, DateTime releaseDate, string categoryNames, int authorId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditByIdAsync(int id, string title, string description, double price, int copies, string edition, int? ageRestriction, DateTime releaseDate, int authorId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> GetTopBooksByTitleAscendingAsync(string search)
        {
            throw new NotImplementedException();
        }
    }
}
