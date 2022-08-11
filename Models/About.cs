using System.ComponentModel.DataAnnotations;

namespace CafeRestaurant.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
