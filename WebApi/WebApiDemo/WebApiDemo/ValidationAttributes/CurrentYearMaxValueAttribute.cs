namespace WebApiDemo.ValidationAttributes
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CurrentYearMaxValueAttribute : ValidationAttribute
    {
        public CurrentYearMaxValueAttribute(int minYear)
        {
            this.MinYear = minYear;
        }

        public int MinYear { get; set; }

        public override bool IsValid(object value)
        {
            if(value is int intValue)
            {
                if(intValue <= DateTime.UtcNow.Year
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
