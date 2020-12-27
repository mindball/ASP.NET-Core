namespace CarDealer.Web.Controllers
{
    using CarDealer.Web.Models.Suppliers;
    using CarDealer.Web.Services;
    using Microsoft.AspNetCore.Mvc;

    public class SuppliersController : Controller
    {
        private readonly ISupplierService supplier;

        public SuppliersController(ISupplierService supplier)
        {
            this.supplier = supplier;
        }

        //This route is by default "{controller=Home}/{action=Index}/{id?}"
        public IActionResult Local()
        {
            var result = this.GetSupplierModelResult(false);

            return this.View("Suppliers", result);
        }

        //This route is by default "{controller=Home}/{action=Index}/{id?}"
        public IActionResult Importers()
        {
            var result = this.GetSupplierModelResult(true);

            return this.View("Suppliers", result);
        }

        private SupplierModel GetSupplierModelResult(bool isImporters)
        {
            var type = isImporters ? "Importers" : "Local";
            var supplierByType = new SupplierModel
            {
                Type = type,
                Suppliers = this.supplier.GetSuppliers(isImporters)
            };

            return supplierByType;
        }

    }
}
