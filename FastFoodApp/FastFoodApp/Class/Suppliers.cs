

namespace FastFoodApp.Class
{
    public class Suppliers
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public List<Product> Products { get; set; } = new();
    }
}
