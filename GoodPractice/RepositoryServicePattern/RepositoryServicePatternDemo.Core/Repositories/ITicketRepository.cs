namespace RepositoryServicePatternDemo.Core.Repositories
{
    using RepositoryServicePatternDemo.Core.Models;
    using System.Collections.Generic;

    public interface ITicketRepository
    {
        List<Ticket> GetAllSold();
    }
}
