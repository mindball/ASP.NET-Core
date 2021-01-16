namespace CameraBazaar.Data.Models.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;

    public class User : IdentityUser
    {
        public List<Camera> Cameras { get; set; } = new List<Camera>();
    }
}
