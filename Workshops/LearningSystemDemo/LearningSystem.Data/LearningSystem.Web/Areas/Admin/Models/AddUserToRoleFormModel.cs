﻿using System.ComponentModel.DataAnnotations;

namespace LearningSystem.Web.Areas.Admin.Models
{
    public class AddUserToRoleFormModel
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
