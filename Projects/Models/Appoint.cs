using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Project2.Models
{
    public class Appoint
    {
        [Key]
        [Required (ErrorMessage = "Please fill the fields")]
        public int AppID { get; set; }
        [Required(ErrorMessage = "Please fill the fields")]
        public int Pid { get; set; }
        [Required(ErrorMessage = "Please fill the fields")]
        public string Special { get; set; }
        [Required(ErrorMessage = "Please fill the fields")]
        public string Doc { get; set; }
        [Required(ErrorMessage = "Please fill the fields")]
        public string Vdate { get; set; }
        [Required(ErrorMessage = "Please fill the fields")]
        public string AppoinTime { get; set; }

    }
}
 