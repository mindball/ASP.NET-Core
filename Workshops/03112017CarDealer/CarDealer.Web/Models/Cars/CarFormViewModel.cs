namespace CarDealer.Web.Models.Cars
{
    using CarDealer.Web.Services.DTO.Part;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class CarFormViewModel
    {
        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        [DisplayName("Travelled Distance")]
        public long TravelledDistance { get; set; }

        public IEnumerable<int> SelectedParts { get; set; }

        [Display(Name = "Parts")]
        public IEnumerable<SelectListItem> AllParts { get; set; }
    }
}
