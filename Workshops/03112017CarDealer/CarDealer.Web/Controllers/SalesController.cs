namespace CarDealer.Web.Controllers
{
    using CarDealer.Web.Services;
    using Microsoft.AspNetCore.Mvc;

    [Route("sales")]
    public class SalesController : Controller
    {
        private readonly ISalesService saleService;

        public SalesController(ISalesService saleService)
        {
            this.saleService = saleService;           
        }

        public IActionResult Index()
        {
            return this.View(this.saleService.GetAllSales());
        }

        [Route("{id?}")]
        public IActionResult Details(int id)
        {
            return this.View(this.saleService.Detail(id));
        }

        [Route("discounted/{discount?}")]
        public IActionResult Discounted(double? discount)
            => this.View(this.saleService.Discounted(discount));

    }
}
