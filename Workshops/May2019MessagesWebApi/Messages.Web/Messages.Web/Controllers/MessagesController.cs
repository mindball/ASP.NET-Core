namespace Messages.Web.Controllers
{
    using Messages.Data;
    using Messages.Web.Models;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : Controller
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
            Message message = new Message
            {
                Content = messageCreateBindingModel.Content,
                User = messageCreateBindingModel.User,
                CreatedOn = DateTime.UtcNow
            };

            await this.context.Messages.AddAsync(message);
            await this.context.SaveChangesAsync();

            return this.Ok();
        }
    }
}
