using System.ComponentModel.DataAnnotations;

namespace CafeRestaurant.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string Twitter { get; set; }
        public string Trip { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
    }
}
