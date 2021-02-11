namespace CreateAdminPanel.Models.Identity
{
    using System.Collections.Generic;

    public class ListUserRolesViewModel
    {
        public string UserId { get; set; }

        public string Email { get; set; }

        public IEnumerable<string> Roles { get; set; }
    }
}
