using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealer.Web.Services.DTO.Part
{
    public class FullPartInfo : PartInfo
    {
        public int Id { get; set; }
       
        public int Quantity { get; set; }

        public string  SupplierName { get; set; }
    }
}
