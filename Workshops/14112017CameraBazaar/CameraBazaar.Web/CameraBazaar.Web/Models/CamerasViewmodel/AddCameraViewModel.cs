namespace CameraBazaar.Web.Models.CamerasViewmodel
{
    
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using CameraBazaar.Data.Models.Enums;
    using Data.Models;

    public class AddCameraViewModel
    {
        [Required]
        public Make Make { get; set; }

        [Required]
        [RegularExpression("^[A-Z0-9-]+$")]
        public string Model { get; set; }

        [Required]
        [Range(typeof(decimal), "0.0", "100000000000000")]
        public decimal Price { get; set; }

        [Required]
        [Range(0, 100)]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Min Shutter Speed")]
        [Range(1, 30)]
        public int MinShutterSpeed { get; set; }

        [Required]
        [Display(Name = "Max Shutter Speed")]
        [Range(2000, 8000)]
        public int MaxShutterSpeed { get; set; }

        [Display(Name = "Min ISO")]
        public MinIso MinISO { get; set; }

        [Display(Name = "Max ISO")]
        public int MaxISO { get; set; }

        [Display(Name = "Full Frame")]
        public bool IsFullFrame { get; set; }

        [Required]
        [Display(Name = "Video Resolution")]
        [StringLength(15)]
        public string Resolution { get; set; }

        [Display(Name = "Light Metering")]
        public IEnumerable<LightMetering> LightMetering { get; set; }

        [Required]
        [StringLength(6000)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Image URL")]
        [StringLength(2000), MinLength(10)]
        public string ImageUrl { get; set; }
    }
}
