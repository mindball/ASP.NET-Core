namespace Messages.Web.Controllers
{
    using Messages.Data;
    using Messages.Web.Models;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
   
    public class MessagesController : BaseController
    {
        private readonly MessagesContext context;

        public MessagesController(MessagesContext context)
        {
            this.context = context;
        }

        [HttpGet(Name = "All")]
        [Route("all")]
        public ActionResult<IEnumerable<Message>> AllOrderedByCreatedOnAscending()
            => this.context.Messages
                .OrderBy(message => message.CreatedOn)
                .ToList();
        

        [HttpPost(Name = "Create")]
        [Route("create")]        
        public async Task<ActionResult> Create(MessageCreateBindingModel messageCreateBindingModel)
        {
            var user = await this.context.Users
                .SingleOrDefaultAsync(u => u.UserName == messageCreateBindingModel.User);                

            if(user == null )
            {
                return this.BadRequest();
            }

            Message message = new Message
            {
                Content = messageCreateBindingModel.Content,
                User = user,
                CreatedOn = DateTime.UtcNow
            };

            await this.context.Messages.AddAsync(message);
            await this.context.SaveChangesAsync();

            return this.Ok();
        }        
    }
}
