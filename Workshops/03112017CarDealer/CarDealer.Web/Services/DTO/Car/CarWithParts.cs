namespace CarDealer.Web.Services.DTO.Car
{
    using CarDealer.Web.Services.DTO.Part;
    using System.Collections.Generic;

    public class CarWithParts : CarMaked
    {
        public IEnumerable<PartInfo> Parts { get; set; }
    }
}
