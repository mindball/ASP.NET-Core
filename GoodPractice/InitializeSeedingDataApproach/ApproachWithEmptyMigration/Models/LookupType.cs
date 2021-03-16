﻿using System;
using System.Collections.Generic;

namespace InitializeSeedingDataApproach.Data.Models
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
