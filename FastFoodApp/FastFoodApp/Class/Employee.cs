using System.ComponentModel.DataAnnotations.Schema;

namespace FastFoodApp.Class
{
    [Table("Employees")]
    public class Employee : User
    {
        public string Name { get; set; } = null!;
        public string SurName { get; set; } = null!;
        public double? Salary { get; set; }
        public int? Age { get; set; }
        public string? Post { get; set; }
        public int? ManagerId { get; set; }
        public Manager? Manager { get; set; }
        public int BlacklistId { get; set; } 
        public Blacklist? Blacklist { get; set; }
    }
}
