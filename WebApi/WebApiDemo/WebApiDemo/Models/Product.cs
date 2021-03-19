namespace WebApiDemo.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using WebApiDemo.ValidationAttributes;

    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MinLength(10)]
        public string Name { get; set; }

        [Range(0, 10000)]
        public decimal Price { get; set; }

        public int SellerId { get; set; }

        public int BuyerId { get; set; }
    }
}
