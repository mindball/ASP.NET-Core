namespace CarDealer.Web.Services.DTO.Part
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class EditPartServiceModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
    }
}
