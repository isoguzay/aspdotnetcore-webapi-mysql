using System.ComponentModel.DataAnnotations;

namespace webapi_mysql.Models
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }     
    }
}