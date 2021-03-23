using AutoMapper;

namespace Automapping.Infrastructure.CustomMapping
{
    public interface IHaveCustomMapping
    {
        void ConfigureMapping(Profile profile);
    }
}
