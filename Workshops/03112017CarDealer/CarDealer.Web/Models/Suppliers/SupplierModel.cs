using CarDealer.Web.Services.DTO.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealer.Web.Models.Suppliers
{
    public class SupplierModel
    {
        public string  Type { get; set; }

        public IEnumerable<FilteredSupplier> Suppliers { get; set; }
    }
}
