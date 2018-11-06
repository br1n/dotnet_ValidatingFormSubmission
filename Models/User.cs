using System.ComponentModel.DataAnnotations;
namespace ValidatingFormSubmission.Models
{
    public class User
    {
        [Required(ErrorMessage="First Name field cannot be blank")]
        [MinLength(4, ErrorMessage="First name must be at least 4 characters long")]
        public string FirstName {get; set;}

        [Required(ErrorMessage="Last Name field cannot be blank")]
        [MinLength(4, ErrorMessage="Last name must be at least 4 characters long")]
        public string LastName {get; set;}

        [Required]
        [Range(0,120, ErrorMessage="No need to lie about your age!")]
        public int Age {get; set;}

        [Required(ErrorMessage="Email field cannot be blank")]
        [EmailAddress(ErrorMessage="Email not valid")]
        public string Email {get; set;}

        [Required(ErrorMessage="Password field cannot be blank")]
        [MinLengthAttribute(8, ErrorMessage="Password must be at least 8 characters")]
        public string Password {get; set;}

        [Required(ErrorMessage="Confirm Password field cannot be blank")]
        [Compare("Password", ErrorMessage="Confirm Password does not match Password")]
        public string ConfirmPassword {get;set;}
    }
}