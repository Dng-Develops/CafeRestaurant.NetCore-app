using System.ComponentModel.DataAnnotations;

namespace CafeRestaurant.Models
{
    public class Category
    {
        [Key] 
        public int Id { get; set; } // Id is a primary key
        
        [Required]
        public string Name { get; set; } // This column is required / not null
    }
}
