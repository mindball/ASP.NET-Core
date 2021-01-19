namespace CameraBazaar.Services.Models
{
    using System.Collections.Generic;
    public class ProfileViewModel
    {
        public UserDetailsModel UserDetails { get; set; }

        public IEnumerable<CameraShortDetailsModel> Cameras { get; set; } = new List<CameraShortDetailsModel>();
    }
}
