using System.ComponentModel.DataAnnotations;

namespace FastFoodApp.Class
{
    public class Coupons
    {
        [Key]
        public int Number { get; set; }
        public string? Description { get; set; }
        public List<Product> Products { get; set; } = new();
    }
}
