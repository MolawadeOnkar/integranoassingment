using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssingmentEx.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage = "please Enter EmailId")]
        [EmailAddress(ErrorMessage = "Invalid EmailId")]
        public String EmailId { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        public String Password { get; set; }
    }
}