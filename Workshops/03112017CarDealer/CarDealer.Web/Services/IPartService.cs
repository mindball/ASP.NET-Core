namespace CarDealer.Web.Services
{
    using CarDealer.Web.Services.DTO.Part;
    using System.Collections.Generic;

    public interface IPartService
    {
        IEnumerable<FullPartInfo> GetAllParts(int page, int pageSize);

        IEnumerable<PartBasicInfoServiceModel> All();

        int Count();

        void Create(string name, decimal price, int quantity, int supplierId);

        void Destroy(int id);

        EditPartServiceModel GetPartById(int id);

        void EditPart(int id, decimal price, int quantity);
    }
}
