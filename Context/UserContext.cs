using Microsoft.EntityFrameworkCore;
using webapi_mysql.Models;

namespace webapi_mysql.Context
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseMySQL("mysql-connection-string-paste-here");
        }
    }
}