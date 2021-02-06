namespace ExercisesBookShopService2017.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    
    using ExercisesBookShopService2017.Services.Models.Author;

    public interface IAuthorService
    {
        Task<GetAuthorByIdServiceModel> GetByIdAsync(int id);

        Task CreateAsync(string firstName, string lastName);

        Task<IEnumerable<GetBooksDetailsServiceModel>> GetBooksAsync(int authorId);

        Task<bool> Exist(int id);
    }
}
