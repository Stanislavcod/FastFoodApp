

namespace FastFoodApp.Class
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<Product> Products { get; set; } = new();
    }
}
