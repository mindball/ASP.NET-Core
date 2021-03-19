namespace ConsoleApp1
{    
    using System.Threading.Tasks;

    public class AuthorService : IAuthorService
    {
        public Task CreateAsync(string firstName, string lastName)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Exist(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
