using System.ComponentModel.DataAnnotations;

namespace _82_MVC_StateManagement.Models
{
    public class Login
    {
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
