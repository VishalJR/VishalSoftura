using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project2.Models
{
    public class AddPatient
    {
        [Key]
        
        [Required(ErrorMessage = "Please fill the fields")]
        public int Pid { get; set; }
        [Required(ErrorMessage = "Please fill the fields")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "special characters not allowed")]
        public string Fname { get; set; }
        [Required(ErrorMessage = "Please fill the fields")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "special characters not allowed")]
        public string Lname { get; set; }
        [Required(ErrorMessage = "Please fill the fields")]
        
        public String Gender { get; set; }
        [Required(ErrorMessage = "Please fill the fields")]
        
        
        
        public string DoB { get; set; }

    }
}

