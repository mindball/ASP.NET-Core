using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealer.Web.Services.DTO.Supplier
{
    public class FilteredSupplier
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int NumerOfParts { get; set; }
    }
}
