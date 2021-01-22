using System.ComponentModel.DataAnnotations;

namespace WorkingWithData.ViewModels
{
    //Kenov
    public class CatDetailsModel
    {       
        [Range(1, int.MaxValue)]
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string Name { get; set; }
    }
}