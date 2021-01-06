namespace RepositoryServicePattern.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using RepositoryServicePatternDemo.Core.Services;

    public class TicketController : Controller
    {
        private readonly ITicketService ticketService;

        public TicketController(ITicketService ticketService)
        {
            this.ticketService = ticketService;
        }

        public IActionResult Index()
        {
            var tickets = this.ticketService.GetAllSold();

            return View(tickets);
        }
    }
}
