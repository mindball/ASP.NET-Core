using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Panda.App.Models.Package
{
    public class PackageCreateBindingModel
    {
        public string Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Description invalid.", MinimumLength = 5)]
        public string Description { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter valid doubleNumber")]
        public double Weight { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Description invalid.", MinimumLength = 5)]
        public string ShippingAddress { get; set; }

        [Required]
        public string Recipient { get; set; }

        public string PackageStatus { get; set; }

        public DateTime? EstimatedDeliveryDate { get; set; }
    }
}
