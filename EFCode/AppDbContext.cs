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
        "Server=sqlserver;Database=EFCoreDemo;User Id=sa;Password=Your_password123;TrustServerCertificate=True;");

        }
    }
}
