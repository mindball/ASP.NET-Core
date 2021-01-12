using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarDealer.Web.Models.Cars
{
    public class CarFormViewModel
    {
        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        [DisplayName("Travelled Distance")]
        public long TravelledDistance { get; set; }
    }
}
