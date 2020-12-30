using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealer.Web.Services.DTO.Customer
{
    public class CustomerSales
    {
         
        public string Name { get; set; }

        public int BoughtCarCount { get; set; }

        public double? SpendMoney { get; set; }
    }
}
