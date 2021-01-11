using System.ComponentModel.DataAnnotations;

namespace TempDataDemo.Models
{
    public class HomeIndexVM
    {
        [Display(Name = "Type a message: ")]
        public string Message { get; set; }

        [Display(Name = "Type: ")]
        public FlashMessageType Type { get; set; }
    }
}
