using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eventures.Web.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DateTimeFromValidateToAttribute : ValidationAttribute
    {
        public DateTimeFromValidateToAttribute(string dateToCompareToFieldName)
        {
            this.DateToCompareToFieldName = dateToCompareToFieldName;
        }

        private string DateToCompareToFieldName { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime earlierDate = (DateTime)value;

            DateTime laterDate = (DateTime)validationContext.ObjectType.GetProperty(this.DateToCompareToFieldName).GetValue(validationContext.ObjectInstance, null);

            if (laterDate > earlierDate)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Date is not later");
            }
        }
    }
}
