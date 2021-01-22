using System;
using System.ComponentModel.DataAnnotations;

namespace WorkingWithData.ValidationAttributeExample
{
    public class YearValidateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(value is int intValue)
            {
                if (intValue < DateTime.UtcNow.Year)
                    return false;
            }

            return true;
        }
    }
}
