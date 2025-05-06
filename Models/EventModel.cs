using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

public class EventModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Event Name is required.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Start date is required.")]
    [CustomValidation(typeof(EventModel), nameof(ValidateStartDate))]    
    public DateTime StartDate { get; set; } = DateTime.Now.AddDays(1);

    [Required(ErrorMessage = "End date is required.")]
    [CustomValidation(typeof(EventModel), nameof(ValidateEndDate))]
    public DateTime EndDate { get; set; } = DateTime.Now.AddDays(1).AddHours(1);

    [Required(ErrorMessage = "Event Location is required.")]
    public string Location { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;
    
    public UserModel? CreatedBy { get; set; }

    public List<UserModel> Attendees { get; set; } = new List<UserModel>();

    public static ValidationResult? ValidateStartDate(DateTime startDate, ValidationContext context)
    {
        if (startDate < DateTime.Now)
        {
            return new ValidationResult("Start date cannot be in the past.");
        }
        return ValidationResult.Success;
    }

        public static ValidationResult? ValidateEndDate(DateTime endDate, ValidationContext context)
    {
        var instance = context.ObjectInstance as EventModel;
        if (instance != null && endDate <= instance.StartDate)
        {
            return new ValidationResult("End date must be later than the start date.");
        }
        return ValidationResult.Success;
    }
}