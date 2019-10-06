using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DDAC3.Models
{
    public class Order
    {
        public int ID { get; set; }

        [Required]
        public string BooksName { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
