namespace CarDealer.Web.Services
{
    using CarDealer.Web.Services.DTO.Part;
    using System.Collections.Generic;

    public interface IPartService
    {
        IEnumerable<FullPartInfo> GetAllParts(int page, int pageSize);

        int Count();
    }
}
