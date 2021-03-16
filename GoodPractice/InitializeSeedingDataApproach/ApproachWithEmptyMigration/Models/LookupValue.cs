using System;

namespace ApproachWithEmptyMigration.Models
{
    public class LookupValue
    {
        public int Id { get; set; }
        public int LookupTypeId { get; set; }
        public virtual LookupType LookupType { get; set; }
        public String Value { get; set; }
    }
}
