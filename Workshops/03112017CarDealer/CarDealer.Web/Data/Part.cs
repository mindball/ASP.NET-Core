
namespace CarDealer.Web.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Part
    {
        public Part()
        {
            this.PartCars = new HashSet<PartCar>();    
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        public virtual ICollection<PartCar> PartCars { get; set; }
    }
}
