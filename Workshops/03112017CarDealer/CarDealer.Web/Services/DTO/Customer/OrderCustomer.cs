using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealer.Web.Services.DTO.Customer
{
    public class OrderCustomer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public bool IsYoungDriver { get; set; }
    }
}
