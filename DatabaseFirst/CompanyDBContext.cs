
using EFCode.Model;
using Microsoft.EntityFrameworkCore;

internal class CompanyDBContext : DbContext
{
    public DbSet<Employee> employee { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
    "Server=localhost,1433;Database=AppDb;User Id=sa;Password=YourStrong!Pass123;TrustServerCertificate=True;");
    }
}
