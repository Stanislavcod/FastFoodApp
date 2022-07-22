using System.ComponentModel.DataAnnotations;

namespace FastFoodApp.Class
{
    public class Combo
    {
        [Key]
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public double Price { get; set; }
        public List<Product> Products { get; set; } = new();
    }
}
