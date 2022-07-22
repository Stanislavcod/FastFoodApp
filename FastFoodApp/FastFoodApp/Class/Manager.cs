using System.ComponentModel.DataAnnotations.Schema;

namespace FastFoodApp.Class
{
    [Table("Managers")]
    public class Manager : User
    {
        public List<Employee> Employees { get; set; } = new();
        public int DepartamentId { get; set; }
        public Departament? Departament { get; set; }
        public int BlacklistId { get; set; }
        public Blacklist? Blacklist { get; set; }
    }
}
