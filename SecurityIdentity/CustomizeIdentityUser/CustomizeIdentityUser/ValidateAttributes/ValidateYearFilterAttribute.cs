namespace CustomizeIdentityUser.ValidateAttributes
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ValidateYearFilterAttribute : ValidationAttribute
    {
        public ValidateYearFilterAttribute(int minYear)
        {
            MinYear = minYear;
            this.ErrorMessage = $"Value should be between {minYear} and {DateTime.UtcNow.Year}.";
        }

        public int MinYear { get; }

        public override bool IsValid(object value)
        {
            if (value is int intValue)
            {
                if (intValue <= DateTime.UtcNow.Year
                    && intValue >= MinYear)
                {
                    return true;
                }
            }

            if (value is DateTime dtValue)
            {
                if (dtValue.Year <= DateTime.UtcNow.Year
                    && dtValue.Year >= MinYear)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
