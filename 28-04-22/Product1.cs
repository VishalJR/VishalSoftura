using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameWorkCore2.Models
{
    public class Product1
    {
        [Key]
        [Required]

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public DateTime DoM { get; set; }
        public DateTime Expiry { get; set; }

    }
}
