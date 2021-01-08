namespace CarDealer.Web.Models.Parts
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    using Models.Suppliers;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class PartFormViewModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        [Display(Name = "Supplier")]
        public int SupplierId { get; set; }

        public bool IsEdit { get; set; }

        public IEnumerable<SupplierViewModel> AllSuppliers { get; set; }

        //kenov version
        public IEnumerable<SelectListItem> AllSuppliersKenovVersion { get; set; }
    }
}
