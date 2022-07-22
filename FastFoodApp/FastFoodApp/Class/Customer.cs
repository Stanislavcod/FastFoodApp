using System.ComponentModel.DataAnnotations.Schema;

namespace FastFoodApp.Class
{
    [Table("Customer")]
    public class Customer : User
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int CityId { get; set; }
        public City? City { get; set; }
        public List<CreditCard> CreditCards { get; set; } = new();
        public int BlacklistId { get; set; }
        public Blacklist? Blacklist { get; set; }
    }
}
