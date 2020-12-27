namespace CarDealer.Web.Services
{
    using CarDealer.Web.Services.DTO.Supplier;
    using System.Collections.Generic;
    public interface ISupplierService
    {
        IEnumerable<FilteredSupplier> GetSuppliers(bool isImporter);
    }
}
