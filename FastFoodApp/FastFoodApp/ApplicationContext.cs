using Microsoft.EntityFrameworkCore;
using FastFoodApp.Class;


namespace FastFoodApp
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Manager> Managers { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Departament> Departaments { get; set; } = null!;
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<CreditCard> CreditCards { get; set; } = null!;
        public DbSet<Combo> Combos { get; set; } = null!;
        public DbSet<Blacklist> Blacklists { get; set; } = null!;
        public DbSet<Coupons> Coupons { get; set; } = null!;
        public DbSet<Delivery> Deliveries { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Suppliers> Suppliers { get; set; } = null!;
        public DbSet<Warehouse> Warehouses { get; set; } = null!;
        public DbSet<CustomerCard> CustomerCards { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Login = "kate",
                Password = "ge1w4wg6ewg4",
                Age = 22,
                Name = "Kate",
                Post = "Povar",
                SurName = "Piratova",
                Salary = 20000
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Login = "qwerty",
                Password = "gkwog",
                Age = 19,
                Name = "Maria",
                Post = "kassir",
                SurName = "Kasssirova",
                Salary = 15000
            });
            modelBuilder.Entity<CustomerCard>((pc =>
            {
                pc.HasNoKey();
                pc.ToView("CustomerCard");
            }));
        }
    }
}
