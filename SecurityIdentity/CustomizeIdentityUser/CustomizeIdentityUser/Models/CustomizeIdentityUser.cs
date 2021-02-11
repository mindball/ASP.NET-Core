namespace CustomizeIdentityUser.Models
{    
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.ComponentModel.DataAnnotations;

    using ValidateAttributes;

    public class CustomizeIdentityUser : IdentityUser
    {
        [Required]
        public string  FirstName { get; set; }

        [Required]
        public string  LastName { get; set; }

        [Required]
        [ValidateYearFilter(1900)]
        public DateTime DateOfBird { get; set; }
    }
}
