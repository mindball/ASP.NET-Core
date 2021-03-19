namespace ConsoleApp1
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IAuthorService
    {       
        Task CreateAsync(string firstName, string lastName);        

        Task<bool> Exist(int id);
    }
}
