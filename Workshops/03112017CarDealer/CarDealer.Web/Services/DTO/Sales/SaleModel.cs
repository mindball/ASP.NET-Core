namespace CarDealer.Web.Services.DTO.Sales
{
    using CarDealer.Web.Services.DTO.Car;
    public class SaleModel : CarMaked
    {
        public int SaleId { get; set; }

        public decimal Discount { get; set; }

        public string CustomerName { get; set; }

        public decimal TotalPrice { get; set; }

    }
}
