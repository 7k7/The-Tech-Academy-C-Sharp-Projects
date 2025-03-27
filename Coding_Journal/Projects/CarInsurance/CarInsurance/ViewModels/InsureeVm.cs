using System.ComponentModel.DataAnnotations;

namespace CarInsurance.ViewModels
{
    public class InsureeVm
    {
        [Display(Name = "Insurance Quote:")]
        public required decimal Quote { get; set; }

        [Display(Name = "First Name:")]
        public required string FirstName { get; set; }

        [Display(Name = "Last Name:")]
        public required string LastName { get; set; }

        [Display(Name = "Email Address:")]
        public required string EmailAddress { get; set; }
    }
}
