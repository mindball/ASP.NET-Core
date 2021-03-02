namespace Eventures.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Order
    {
        public Order()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        public DateTime OrderedOn { get; set; }

        [Required]
        public string EventId { get; set; }

        public virtual Event Event { get; set; }

        [Required]
        public int TicketsCount { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual EventuresUser User { get; set; }        
    }
}
