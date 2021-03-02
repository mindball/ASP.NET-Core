namespace Eventures.Services.DTO
{
    using Eventures.Infrastructure.Mapping;
    using Eventures.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class EventServiceModel : IMapWith<Event>
    {
        public string Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Place { get; set; }

        //TODO : make validation attribute to validate start with end date
        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public int TotalTickets { get; set; }

        [Required]
        public decimal PricePerTicket { get; set; }

        //public ICollection<OrderServiceModel> Orders { get; set; } = new List<OrderServiceModel>();
    }
}
