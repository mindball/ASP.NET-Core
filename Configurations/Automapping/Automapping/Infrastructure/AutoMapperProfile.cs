using AutoMapper;
using Automapping.Data;
using Automapping.Infrastructure.CustomMapping;
using Automapping.Services.Models;
using System;
using System.Linq;
using System.Reflection;

namespace Automapping.Infrastructure
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //basic match properties names mappings  (PassportNumber is null)
            //this.CreateMap<Person, PersonCustomServiceModel>();

            //basic match with custom properties names mappings  (PassportNumber is filled)
            //this.CreateMap<Person, PersonCustomServiceModel>()
            //    .ForMember(u => u.PassportNumber, cfg =>
            //        cfg.MapFrom(p => p.Passport.PassportId)
            //    );

            var allTypes =  AppDomain
               .CurrentDomain
               .GetAssemblies()
               .Where(a => a.GetName().Name.Contains("Automapping"))
               .SelectMany(a => a.GetTypes());

            allTypes
                .Where(t => t.IsClass
                        && !t.IsAbstract
                        && t.GetInterfaces()
                                .Where(i => i.IsGenericType)
                                .Select(i =>
                                    i.GetGenericTypeDefinition())
                                        .Contains(typeof(IMapFrom<>)))
                .Select(t => new
                {
                    Destination = t,
                    Source = t.GetInterfaces()
                        .Where(i => i.IsGenericType)
                        .Select(i => new
                        {
                            Definition = i.GetGenericTypeDefinition(),
                            Arguments = i.GetGenericArguments()
                        })
                        .Where(i => i.Definition == typeof(IMapFrom<>))
                        .SelectMany(i => i.Arguments)
                        .FirstOrDefault()
                })
                .ToList()
                .ForEach(a => this.CreateMap(a.Source, a.Destination));

            allTypes
                .Where(t => t.IsClass && !t.IsAbstract && typeof(IHaveCustomMapping)
                .IsAssignableFrom(t))
                .Select(Activator.CreateInstance)
                .Cast<IHaveCustomMapping>()
                .ToList()
                .ForEach(t => t.ConfigureMapping(this));
        }
    }
}
