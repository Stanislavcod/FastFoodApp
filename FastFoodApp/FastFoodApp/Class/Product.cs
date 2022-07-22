using FastFoodApp.Migrations;

namespace FastFoodApp.Class
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public int WareHouseId { get; set; }
        public Warehouse? WareHouse { get; set; }
        public List<Coupons> Coupons { get; set; } = new();
        public List<Combo> Combos { get; set; } = new();
        public int SuppliersId { get; set; }
        public Suppliers? Suppliers { get; set; }

    }
}
