namespace CameraBazaar.Data.Models
{
    using CameraBazaar.Data.Models.Models;
    using System.ComponentModel.DataAnnotations;

    public class Camera
    {
        public int Id { get; set; }

        [Required]
        public CameraMake Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        [Range(typeof(decimal), "0.0", "100000000000000")]
        public decimal Price { get; set; }

        [Required]
        [Range(0, 100)]
        public int Quantity { get; set; }

        [Required]
        [Range(1, 30)]
        public int MinShutterSpeed { get; set; }

        [Required]
        [Range(2000, 8000)]
        public int MaxShutterSpeed { get; set; }

        public MinIso MinISO { get; set; }

        public int MaxISO { get; set; }

        public bool IsFullFrame { get; set; }

        [Required]
        [StringLength(15)]
        public string Resolution { get; set; }

        public LightMetering LightMetering { get; set; }

        [Required]
        [StringLength(6000)]
        public string Description { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(2000)]
        public string ImageUrl { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }
    }
}