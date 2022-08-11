using System;
using System.ComponentModel.DataAnnotations;

namespace CafeRestaurant.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone{ get; set; }

        public int People { get; set; }
        public string Time { get; set; }
        public DateTime Date { get; set; }
    }
}
