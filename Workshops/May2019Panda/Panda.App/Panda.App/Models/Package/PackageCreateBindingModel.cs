namespace Panda.App.Models.Package
{
    using System;
    using System.ComponentModel.DataAnnotations;

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

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        public DateTime? EstimatedDeliveryDate { get; set; }
    }
}
