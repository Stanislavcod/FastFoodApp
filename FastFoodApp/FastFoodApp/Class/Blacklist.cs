using System.ComponentModel.DataAnnotations;


namespace FastFoodApp.Class
{
    public class Blacklist
    {
        [Key]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<Employee> Employees { get; set; } = new();
        public List<Manager> Managers { get; set; } = new();
        public List<Customer> Customers { get; set; } = new();
    }
}
