using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkingWithData.ValidationAttributeExample;

namespace WorkingWithData.Models.ValidateAttribute
{
    public class AttributeExamleVIewModel
    {
        [YearValidate]
        public int Year { get; set; }
    }
}
