using System.Globalization;
using System.Windows.Controls;

namespace RussianMultiplication.Validators
{
    public class IntValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value is string input && int.TryParse(input, out int intValue))
            {
                return intValue >= 0
                    ? ValidationResult.ValidResult
                    : new ValidationResult(false, "Negative numbers are not allowed.");
            }

            return new ValidationResult(false, "Please enter a valid integer.");
        }
    }
}