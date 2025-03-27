using System.ComponentModel.DataAnnotations;

namespace CarInsurance.Models
{
    public class Insuree
    {
        public Guid Id { get; set; }

        [Display(Name = "First Name")]
        public required string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public required string LastName { get; set; }

        [Display(Name = "Email Address")]
        public required string EmailAddress { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public required DateTime DateOfBirth { get; set; }

        [Display(Name = "Car Year")]
        public required int CarYear { get; set; }

        [Display(Name = "Car Make")]
        public required string CarMake { get; set; }

        [Display(Name = "Car Model")]
        public required string CarModel { get; set; }

        [Display(Name = "Do you have a DUI?")]
        public required bool DUI { get; set; }

        [Display(Name = "Number of Speeding Tickets")]
        public required int SpeedingTickets { get; set; }

        [Display(Name = "Coverage Type (true = full, false = liability)")]
        public required bool CoverageType { get; set; }

        [Display(Name = "Insurance Quote ($)")]
        [DataType(DataType.Currency)]
        public decimal Quote { get; set; }
    }
}
