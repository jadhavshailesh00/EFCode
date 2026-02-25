using EFCode.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EFCode
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> student { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
        "Server=localhost,1433;Database=AppDb;User Id=sa;Password=YourStrong!Pass123;TrustServerCertificate=True;");
        }
    }
}
