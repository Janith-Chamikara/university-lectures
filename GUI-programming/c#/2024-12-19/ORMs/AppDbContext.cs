using Microsoft.EntityFrameworkCore;

namespace ORMs;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public string DbPath { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        DbPath = "./db/products.db";
        options.UseSqlite($"Data Source={DbPath}");
    }
}
