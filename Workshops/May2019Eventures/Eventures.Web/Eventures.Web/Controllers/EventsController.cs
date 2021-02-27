namespace Eventures.Web.Controllers
{
    using AutoMapper;
    using Eventures.Infrastructure;
    using Eventures.Services;
    using Eventures.Services.DTO;
    using Eventures.Web.Models.Events;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class EventsController : Controller
    {
        private readonly IEventsService eventsService;
        private readonly ILogger logger;

        public EventsController(IEventsService eventsService, ILogger<EventsController> logger)
        {
            this.eventsService = eventsService;
            this.logger = logger;
        }

        [Authorize]
        public async Task<IActionResult> All()
        {
            var events = (await this.eventsService.GetAll())
                .Select(Mapper.Map<ListingViewModel>)
                .ToArray();

            return this.View(events);
        }

        [Authorize(Roles = GlobalConstants.AdminRoleName)]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdminRoleName)]
        //TODO: [TypeFilter(typeof(AdminCreateLoggerActionFilterAttribute))]
        public async Task<IActionResult> Create(CreateViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var serviceModel = Mapper.Map<EventServiceModel>(model);

            await this.eventsService.CreateAsync(serviceModel);

            this.logger.LogInformation("Event created: " + serviceModel.Name, serviceModel);

            return this.RedirectToAction("All");
        }
    }
}
