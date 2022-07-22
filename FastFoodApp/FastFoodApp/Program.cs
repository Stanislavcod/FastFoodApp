using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using FastFoodApp.Class;
using FastFoodApp;
using Microsoft.Data.SqlClient;

//configuration settings
var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile("appsettings.json");
var config = builder.Build();
string connectionString = config.GetConnectionString("DefaultConnection");
var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
var options = optionsBuilder.UseSqlServer(connectionString).Options;

using (ApplicationContext db = new ApplicationContext(options))
{
    User user1 = new User { Login = "stas", Password = "12345" };
    User user2 = new User { Login = "dima", Password = "154792" };
    db.Users.AddRange(user1,user2);

    Departament departament1 = new Departament { Name = "Кухня" };
    db.Departaments.Add(departament1);

    Manager manager1 = new Manager { Login = "dimasik", Password = "5fqffq", Departament = departament1 };
    db.Managers.Add(manager1);

    Employee employee2 = new Employee { Manager = manager1, Login = "dimasik02", Password = "egGe5g", Name = "Dmitry", SurName = "Magamedov" };
    Employee employee1 = new Employee { Age = 21, Login = "stasik", Password = "44458", SurName = "rassrt",Name = "Stas" };
    db.Employees.AddRange(employee1,employee2);

    City city1 = new City { Name = "Brest" };
    db.Cities.Add(city1);

    Customer customer1 = new Customer { Name = "Andry", Login = "gegq5g5", Password = "fqqggq", City = city1, Address= "Masherova" };
    Customer customer2 = new Customer { Name = "Gena", Login = "qwertyui", Password = "65926", City = city1, Address = "Ledoviy" };
    db.Customers.AddRange(customer1,customer2);

    CreditCard creditCard1 = new CreditCard { Customer = customer1, CVV = 859, Number = "1578 7458 8562 9535" };
    db.CreditCards.Add(creditCard1);
    db.SaveChanges();


    //Include
    var customers = db.Customers.Include(c => c.City).ToList();
    foreach(var i in customers)
        Console.WriteLine($"Name Customer={i.Name} from {i.City?.Name}");

    var customerInfo = db.Customers.ToList();
    foreach (var item in customerInfo)
        Console.WriteLine($"Name= {item.Name}, Цена: {item.Address}, Пароль: {item.Password} Логин {item.Login}");

    var customercarder = db.CustomerCards.ToList();
    foreach (var item in customercarder)
    {
        Console.WriteLine($"Customer: {item.CustomerName} Addres: {item.CustomerAddres} CardNumber: {item.Number}");
    }
    //SqlParameter param = new("@name", "Microsoft");
    //var users = db.Users.FromSqlRaw("GetUsersByCompany @name", param).ToList();
    //foreach (var p in users)
    //    Console.WriteLine($"{p.Name} - {p.Age}");

}
