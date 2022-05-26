using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Project2.Models
{
    public class AddDoctor
    {
        [Key]
        [Required(ErrorMessage = "Please fill the fields")]
        public int DoctorId { get; set; }
        [Required(ErrorMessage = "Please fill the fields")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please fill the fields")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "special characters not allowed")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Choose the options")]
        public string Sex { get; set; }
        [Required(ErrorMessage = "Please fill the fields")]
        public string Specialization { get; set; }
        [Required(ErrorMessage = "Please fill the fields")]
        public string VistingHours { get; set; }
    }
}

