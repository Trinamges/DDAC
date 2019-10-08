using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DDAC3.Models
{
    public class Book
    {
        [JsonProperty(PropertyName = "id")]
        public string ID { get; set; }

        [JsonProperty(PropertyName = "bookName")]
        [Display(Name = "Book Name")]
        [Required]
        public string BookName { get; set; }

        [JsonProperty(PropertyName = "author")]
        [Required]
        public string Author { get; set; }

        [JsonProperty(PropertyName = "price")]
        [Column(TypeName = "decimal(18,2)")]
        [Range(1, 100)]
        [Required]
        public decimal Price { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        [Required]
        public int Quantity { get; set; }
    }
}
