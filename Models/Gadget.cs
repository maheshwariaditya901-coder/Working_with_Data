using System.ComponentModel.DataAnnotations;

namespace Working_with_Data.Models
{
    public class Gadget
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }
    } 
}
