﻿namespace CarDealer.Web.Models.Customers
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class CustomerFormViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        public bool IsYoungDriver { get; set; }
    }
}
