using Automapping.Data;
using Automapping.Infrastructure;

namespace Automapping.Services.Models.BaseMapping
{
    public class PersonCustomServiceModel : IMapFrom<Person>
    {
        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public decimal Salary { get; set; }

        public string PassportNumber { get; set; }
    }
}
