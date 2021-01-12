namespace CarDealer.Web.Services.DTO.Sales
{
    using CarDealer.Web.Services.DTO.Car;

    //refactoring
    public class SaleModel  // : CarMaked
    {
        public int SaleId { get; set; }

        public FullDetailCarSericeModel CarMaked { get; set; }

        public decimal Discount { get; set; }

        public string CustomerName { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
