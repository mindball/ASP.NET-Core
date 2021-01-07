
namespace CarDealer.Web.Models.Suppliers
{
    using CarDealer.Web.Services.DTO.Supplier;
    using System.Collections.Generic;

    public class SupplierModel
    {
        public string Type { get; set; }

        public IEnumerable<FilteredSupplier> Suppliers { get; set; }
    }
}
