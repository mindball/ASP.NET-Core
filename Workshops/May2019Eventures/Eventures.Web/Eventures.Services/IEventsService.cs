namespace Eventures.Services
{
    using Eventures.Services.DTO;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IEventsService
    {
        Task CreateAsync(EventServiceModel model);

        Task<IEnumerable<EventServiceModel>> GetAll();
    }
}
