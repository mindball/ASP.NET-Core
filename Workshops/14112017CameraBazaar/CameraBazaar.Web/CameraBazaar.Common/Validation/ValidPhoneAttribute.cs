
namespace CameraBazaar.Common.Validation
{
    using System.ComponentModel.DataAnnotations;
    using System.Text.RegularExpressions;

    public class ValidPhoneAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var phone = value as string;

            if (phone is null)
            {
                return false;
            }

            string pattern = @"^\+\d{10,12}$";

            Regex rgx = new Regex(pattern);

            return rgx.IsMatch(phone);
        }
    }
}
