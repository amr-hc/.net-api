using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Models
{
    public class Mydb : DbContext
    {
        public DbSet<Product> products { get; set; }
        public Mydb()
        { }


        public Mydb(DbContextOptions context) : base(context)
        { }
    }
}
