using EFDemo.DB_Lib.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDemo.DB_Lib;

public class DataBase : DbContext
{
    public DbSet<Person>? TablePersons { get; set; }
    public DbSet<User>? TableUsers { get; set; }

    public DataBase() : base() { }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlite(@"Data Source=D:\Programming\Education\ITStep\Shambala\EFDemo\EFDemo\users.db");
    }
}