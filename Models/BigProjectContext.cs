using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BigProject.Models;

namespace BigProject.Models
{
    public class BigProjectContext : DbContext
    {
        public BigProjectContext(DbContextOptions<BigProjectContext> options) : base(options) {}

        public DbSet<User> Users {get; set;}
        public DbSet<Login> Logins {get; set;}
        public DbSet<Activities> Activities { get; set; }
        public DbSet<Guest> Guests {get; set;}

        public void CreateUser(User newUser, HttpContext context)
        {
            PasswordHasher<User> Hasher = new PasswordHasher<User>();
            newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
            Add(newUser);
            SaveChanges();
            User oneUser = Users.Last();
            int x = oneUser.UserId;
            context.Session.SetInt32("uid", x);
        }

        public void LoginUser(Login newLogin, HttpContext context)
        {
            User oneUser = Users
                .FirstOrDefault(log => log.Email == newLogin.lemail);
            var hasher = new PasswordHasher<Login>();
            var result = hasher.VerifyHashedPassword(
                newLogin, oneUser.Password, newLogin.lpassword
            );
            context.Session.SetInt32("uid", oneUser.UserId);
        }
    }
}