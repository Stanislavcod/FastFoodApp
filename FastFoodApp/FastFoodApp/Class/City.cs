

namespace FastFoodApp.Class
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public List<Customer> Customers { get; set; } = new();
    }
}
