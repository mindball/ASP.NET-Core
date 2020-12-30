namespace CarDealer.Web.Services
{
    using CarDealer.Web.Services.DTO.Sales;
    using System.Collections.Generic;
    public interface ISalesService
    {
        IEnumerable<SaleModel> GetAllSales();

        SaleDetailById Detail(int id);

        IEnumerable<SaleModel> Discounted(double? discount);
    }
}
