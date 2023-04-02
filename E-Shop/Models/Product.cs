using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_Shop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }
        
        [DefaultValue(0.0)]
        public double Price { get; set; }

        public string? ImageUrl { get; set; }
        
        [DefaultValue(0.0)]
        public int Stock { get; set; }

        public string? Material { get; set; }

        public string? Color { get; set; }

        public string? Brand { get; set; }
    }
}
