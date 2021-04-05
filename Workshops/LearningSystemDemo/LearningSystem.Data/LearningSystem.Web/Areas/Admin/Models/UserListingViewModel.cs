﻿using LearningSystem.Services.Admin.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace LearningSystem.Web.Areas.Admin.Models
{
    public class UserListingViewModel 
    {
        public IEnumerable<AdminUserListingServiceModel> Users { get; set; }

        public IEnumerable<SelectListItem> Roles { get; set; }
    }
}
