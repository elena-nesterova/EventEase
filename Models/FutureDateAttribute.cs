
using System.ComponentModel.DataAnnotations;

public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is DateTime date)
        {
            if (date >= DateTime.Now.Date)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("The date must be in the future.");
        }
        return new ValidationResult("Invalid date format.");
    }
}