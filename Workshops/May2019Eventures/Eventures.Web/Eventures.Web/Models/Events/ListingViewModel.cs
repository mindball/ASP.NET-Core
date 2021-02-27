namespace Eventures.Web.Models.Events
{
    using Eventures.Infrastructure.Mapping;
    using Eventures.Services.DTO;
    using System;

    public class ListingViewModel : IMapWith<EventServiceModel>
    {
        public string Name { get; set; }

        public string Place { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
