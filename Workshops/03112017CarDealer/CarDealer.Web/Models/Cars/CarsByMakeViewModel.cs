namespace CarDealer.Web.Models.Cars
{
    using CarDealer.Web.Services.DTO.Car;
    using System.Collections.Generic;
    public class CarsByMakeViewModel
    {
        public IEnumerable<CarMaked> CarsByMake { get; set; }

        public string Maker { get; set; }
    }
}
