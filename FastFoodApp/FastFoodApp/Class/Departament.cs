

namespace FastFoodApp.Class
{
    public class Departament
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Manager> Managers { get; set; } = new();
    }
}
