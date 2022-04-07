using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssingmentEx.Models
{
    public class User
    {
        [Key]
        public Int64 UserId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String EmailId { get; set; }
        public String Password { get; set; }
    }
}