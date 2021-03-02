namespace Eventures.Services
{
    using Eventures.Services.DTO;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IEventsService
    {
        void Create(EventServiceModel model);

        Task<IEnumerable<EventServiceModel>> GetAll();
    }
}
