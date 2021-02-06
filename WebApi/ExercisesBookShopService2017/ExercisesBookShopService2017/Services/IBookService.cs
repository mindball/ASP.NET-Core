﻿namespace ExercisesBookShopService2017.Services
{
    using Models.Book;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IBookService
    {
        Task<IEnumerable<GetBooksByIdServiceModel>> GetByIdAsync(int id);

        Task<IEnumerable<GetBookTitleAndIdServiceModel>> GetTopBooksByTitleAscendingAsync(string search);

        Task<bool> EditByIdAsync(int id, string title, string description, double price, int copies, string edition, int? ageRestriction,
            DateTime releaseDate, int authorId);

        Task<int> Create(string title, string description, double price, int copies, string edition,
            int? ageRestriction, DateTime releaseDate, string categoryNames, int authorId);

        Task<bool> Delete(int id);
    }
}
