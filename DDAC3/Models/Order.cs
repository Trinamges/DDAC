using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DDAC3.Models
{
    public class Order
    {
        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "bookName")]
        [Required]
        public string BooksName { get; set; }

        [JsonProperty(PropertyName = "customerName")]
        [Required]
        public string CustomerName { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        [Required]
        public int Quantity { get; set; }
    }
}
