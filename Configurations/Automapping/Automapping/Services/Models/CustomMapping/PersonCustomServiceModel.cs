using AutoMapper;
using Automapping.Data;
using Automapping.Infrastructure;
using Automapping.Infrastructure.CustomMapping;

namespace Automapping.Services.Models.CustomeMapping
{
    public class PersonCustomServiceModel : IMapFrom<Person>, IHaveCustomMapping
    {
        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public decimal Salary { get; set; }

        public string PassportNumber { get; set; }

        public void ConfigureMapping(Profile profile)
        {
            profile.CreateMap<Person, PersonCustomServiceModel>()
                .ForMember(u => u.PassportNumber, cfg =>
                    cfg.MapFrom(p => p.Passport.PassportNumber)
                );
            //.ForMember(може да продължаваме с custome-mapping-а)
        }
    }
}
