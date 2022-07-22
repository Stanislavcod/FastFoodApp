

namespace FastFoodApp.Class
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime? DateTime { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public int? EmployeeId { get; set; }
        public Employee? Employees { get; set; }
        public int ProductId { get; set; }
        public List<Product> Product { get; set; } = new();
        public int ComboId { get; set; }
        public Combo? Combos { get; set; }
        public int CouponsId { get; set; }
        public Coupons? Couponss { get; set; }
    }
}
