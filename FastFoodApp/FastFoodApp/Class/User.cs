using System.ComponentModel.DataAnnotations;

namespace FastFoodApp.Class
{
    public class User
    {
        [Key]
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
