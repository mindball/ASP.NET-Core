namespace CarDealer.Web.Models.Cars
{
    using CarDealer.Web.Services.DTO.Car;
    using System.Collections.Generic;
    public class CarsByMakeViewModel
    {
        public IEnumerable<FullDetailCarSericeModel> CarsByMake { get; set; }

        public string Maker { get; set; }
    }
}
