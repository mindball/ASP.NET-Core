namespace CacheDemo.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Car
    {
        public Car()
        {            
            this.Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public long TravelledDistance { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }       
    }
}