using EFDemo.DB_Lib;
using EFDemo.DB_Lib.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDemo
{
    internal static class Program
    {
        private static void Main()
        {
            var db = new DataBase();

            foreach (var user in db.TableUsers)
            {
                Console.WriteLine($"{user.UserId}: {user?.Person?.LastName} {user?.Person?.FirstName}, {user?.Login}");
            }

            db.TableUsers.Add(new User()
            {
                Login = "Admin2",
                PersonId = 2
            });
            db.SaveChanges();
            
            foreach (var user in db.TableUsers)
            {
                Console.WriteLine($"{user.UserId}: {user?.Person?.LastName} {user?.Person?.FirstName}, {user?.Login}");
            }
        }
    }
}