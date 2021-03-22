using System;

namespace Messages.Data
{
    public class User
    {
        public User()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
