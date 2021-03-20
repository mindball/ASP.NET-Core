namespace Messages.Data
{
    using Microsoft.EntityFrameworkCore;


    public class MessagesContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }    
        
        public DbSet<User> Users { get; set; }        

        public MessagesContext(DbContextOptions options) 
            : base(options)
        {
        }
    }
}
