namespace CameraBazaar.Common.Validation
{
    using System.ComponentModel.DataAnnotations;

    public class RangeDividable : ValidationAttribute
    {
        private int min;
        private int max;
        private int divisor;

        public RangeDividable(int min, int max, int divisor)
        {
            this.min = min;
            this.max = max;
            this.divisor = divisor;
        }

        public override bool IsValid(object value)
        {
            int ISO = 0;

            if (value is null || !int.TryParse(value.ToString(), out ISO) || ISO % divisor != 0 || ISO < min || ISO > max)
            {
                return false;
            }

            return true;
        }
    }
}
