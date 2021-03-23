namespace Automapping.Data
{
    public class Person
    {
        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public decimal Salary { get; set; }

        public int PassportId { get; set; }

        public virtual Passport Passport { get; set; }
    }
}
