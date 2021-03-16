using System;
using System.Collections.Generic;

namespace ApproachWithEmptyMigration.Models
{
    public class LookupType
    {
        public LookupType()
        {
            LookupValues = new List<LookupValue>();
        }

        public int Id { get; set; }
        public String Name { get; set; }

        public virtual ICollection<LookupValue> LookupValues { get; set; }
    }
}
