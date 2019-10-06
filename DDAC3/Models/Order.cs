using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDAC3.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int BooksID { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    }
}
