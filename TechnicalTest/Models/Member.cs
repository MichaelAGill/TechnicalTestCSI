using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TechnicalTest.Models
{
    public class Member
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First name is a required field.")]
        public string FirstName { get; set; }

        [Display(Name = "Surname")]
        [Required(ErrorMessage = "Surname is a required field.")]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email Address is a required field.")]
        public string EmailAddress { get; set; }

        [Display(Name = "Confirm Email Address")]
        [Compare("EmailAddress", ErrorMessage = "The Email and Confirm Email fields must match.")]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password Field is a required field.")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Password must be between 8-50 characters long.")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Confirm Password is a required field.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The Password and Confirm Password fields must match.")]
        public string ConfirmPassword { get; set; }
    }
}