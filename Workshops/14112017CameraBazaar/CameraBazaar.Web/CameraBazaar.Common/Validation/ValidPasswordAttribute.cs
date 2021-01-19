namespace CameraBazaar.Common.Validation
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Text.RegularExpressions;

    [AttributeUsage(AttributeTargets.Property)]
    public class ValidPasswordAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var password = value as string;

            string pattern = @"^[a-z0-9]{3,}$";

            Regex rgx = new Regex(pattern);

            return rgx.IsMatch(password);
        }
    }
}
