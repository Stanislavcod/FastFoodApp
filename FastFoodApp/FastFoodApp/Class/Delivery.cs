

namespace FastFoodApp.Class
{
    public class Delivery
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order? Order { get; set; }
        public DateTime DateTime { get; set; }
        public string? Status { get; set; }
        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
