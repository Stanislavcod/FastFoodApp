using System.ComponentModel.DataAnnotations;

namespace FastFoodApp.Class
{
    public class CreditCard
    {
        [Key]
        public string Number { get; set; } = null!;
        public int CVV { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}
