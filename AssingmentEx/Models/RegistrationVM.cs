using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssingmentEx.Models
{
    public class RegistrationVM
    {
        [Required(ErrorMessage = "please Enter FirstName")]
        public String FirstName { get; set; }
        [Required(ErrorMessage = "Please Enter LastName")]
        public String LastName { get; set; }
        [Required(ErrorMessage = "Please Enter your BirthDate")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Please Enter Your MailId")]
        [EmailAddress(ErrorMessage = "Invalid EmailAddress")]
        public String EmailId { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
        public String Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirm Password And Password Not Match")]
        public String ConfirmPassword { get; set; }
    }
}