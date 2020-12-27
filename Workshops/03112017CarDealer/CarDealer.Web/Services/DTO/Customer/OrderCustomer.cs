
namespace CarDealer.Web.Services.DTO.Customer
{
    using System;

    public class OrderCustomer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public bool IsYoungDriver { get; set; }
    }
}
