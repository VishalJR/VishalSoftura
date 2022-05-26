using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Project2.Models
{
    public class User
    {

        public string Username { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "special characters not allowed")]
        public string Fname { get; set; }
        public string Lname { get; set; }
        [Required]
        

        public string Password { get; set; }


    }
}

