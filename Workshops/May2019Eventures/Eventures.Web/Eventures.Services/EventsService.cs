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
    using System.Linq;

    public class EventsService : DataService, IEventsService
    {
        public EventsService(EventuresDbContext context) 
            : base(context)
        {
        }

        public void Create(EventServiceModel model)
        {
            if (!this.IsEntityStateValid(model))
            {
                return;
            }

            var @event = new Event
            {
                Name = model.Name,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                Place = model.Place
            };

            this.context.Add(@event);

            this.context.SaveChanges();
        }

        public async Task<IEnumerable<EventServiceModel>> GetAll()
             => await this.context
                .Events.Select(a => new EventServiceModel
                {
                    Name = a.Name,
                    StartDate = a.StartDate,
                    EndDate = a.EndDate,
                    Place = a.Place
                })
            .ToListAsync();
               
               
        
    }
}
