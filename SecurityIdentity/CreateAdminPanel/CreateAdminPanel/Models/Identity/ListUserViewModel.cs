namespace CreateAdminPanel.Models.Identity
{
    using System.Collections.Generic;

    public class ListUserViewModel
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public IEnumerable<string> Roles { get; set; }
    }
}
