using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Models
{
    public class Mydb : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Product> products { get; set; }
        public DbSet<Category> Category { get; set; }
        public Mydb()
        { }


        public Mydb(DbContextOptions context) : base(context)
        { }
    }
}
