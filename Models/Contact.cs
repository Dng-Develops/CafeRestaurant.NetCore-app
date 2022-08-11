using System;
using System.ComponentModel.DataAnnotations;

namespace CafeRestaurant.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="Please enter email adress")]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }

        [Required]
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
