namespace Panda.Domain
{
    using Microsoft.AspNetCore.Identity;

    public class PandaUserRole : IdentityRole
    {
        public PandaUserRole(string Name)
        {
            this.Name = Name;
        }
    }
}