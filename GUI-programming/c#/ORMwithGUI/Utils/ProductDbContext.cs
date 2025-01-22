using Microsoft.EntityFrameworkCore;
namespace ORMwithGUI.Utils;
using ORMwithGUI.Models;

public class ProductDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public string DbPath { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        DbPath = "../db/products.db";
        options.UseSqlite($"Data Source={DbPath}");
    }
}
