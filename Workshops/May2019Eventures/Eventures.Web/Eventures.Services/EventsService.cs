namespace Eventures.Services
{
    using AutoMapper;
    
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Eventures.Data;
    using Eventures.Services.DTO;
    using Eventures.Models;
    using AutoMapper.QueryableExtensions;
    using Microsoft.EntityFrameworkCore;

    public class EventsService : DataService, IEventsService
    {
        public EventsService(EventuresDbContext context) 
            : base(context)
        {
        }

        public async Task CreateAsync(EventServiceModel model)
        {
            if (!this.IsEntityStateValid(model))
            {
                return;
            }

            var ev = Mapper.Map<Event>(model);

            await this.context.AddAsync(ev);

            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<EventServiceModel>> GetAll()
             =>  await this.context.Events
               .ProjectTo<EventServiceModel>()
               .ToArrayAsync();
        
    }
}
