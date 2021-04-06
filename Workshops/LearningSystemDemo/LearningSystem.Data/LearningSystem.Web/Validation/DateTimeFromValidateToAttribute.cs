using System;
using System.ComponentModel.DataAnnotations;

namespace LearningSystem.Web.Validation
{
    //Repeat validattion 
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
            
            return new ValidationResult("Later date  is equal or less than Start date");
            
        }
    }
}
