namespace Eventures.Services.DTO
{
    using Eventures.Infrastructure.Mapping;
    using Eventures.Models;
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    //TODO: inherit IdentityUser
    public class UserServiceModel : IdentityUser, IMapWith<EventuresUser>
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string UniqueCitizenNumber { get; set; }
    }
}
