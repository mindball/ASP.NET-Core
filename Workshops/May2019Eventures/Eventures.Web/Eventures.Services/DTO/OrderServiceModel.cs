namespace Eventures.Services.DTO
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Eventures.Models;
    using Infrastructure.Mapping;

    public class OrderServiceModel : IMapWith<Order>
    {
        public string Id { get; set; }

        [Required]
        public DateTime OrderedOn { get; set; }

        public string EventId { get; set; }

        public EventServiceModel Event { get; set; }

        public string UserId { get; set; }

        public UserServiceModel User { get; set; }

        [Required]
        public int TicketsCount { get; set; }
    }
}
