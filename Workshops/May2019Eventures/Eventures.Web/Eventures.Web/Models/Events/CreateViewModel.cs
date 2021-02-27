namespace Eventures.Web.Models.Events
{
    using Eventures.Infrastructure.Mapping;
    using Eventures.Services.DTO;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CreateViewModel : IMapWith<EventServiceModel>
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Place { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Required]
        [Display(Name = "Total Tickets")]
        public int TotalTickets { get; set; }

        [Required]
        [Display(Name = "Price Per Ticket")]
        public decimal PricePerTicket { get; set; }
    }
}
