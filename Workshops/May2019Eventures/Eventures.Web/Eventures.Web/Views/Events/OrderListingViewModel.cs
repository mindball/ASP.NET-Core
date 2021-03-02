namespace Eventures.Web.Views.Events
{
    using System;
    using AutoMapper;
    using Eventures.Web.Models.Events;
    using Infrastructure.Mapping;
    using Services.DTO;

    public class OrderListingViewModel : IHaveCustomMapping
    {
        public ListingViewModel Event { get; set; }

        public string UserName { get; set; }

        public DateTime OrderedOn { get; set; }

        public int TicketsCount { get; set; }

        public void ConfigureMapping(Profile mapper)
        {
            mapper.CreateMap<OrderServiceModel, OrderListingViewModel>()
                .ForMember(dest => dest.UserName, opt =>
                    opt.MapFrom(src => src.User.UserName));
        }
    }
}
