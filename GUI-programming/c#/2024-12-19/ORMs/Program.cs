using Microsoft.EntityFrameworkCore;
using ORMs;

AppDbContext db = new AppDbContext();
db.Database.EnsureDeleted();
db.Database.EnsureCreated();

for (int i = 0; i < 10; i++)
{
    Product product = new Product()
    {
        Name = $"Product {i + 1}",
        Price = 1000.50 + i,
        Quantity = 1 + i,
    };
    db.Products.Add(product);
}

db.SaveChanges();


Product existingProduct = db.Products.FirstOrDefault(p => p.Id == 2);
Console.WriteLine($"EXISTING PRODUCT - {existingProduct.Name}");
existingProduct.Name = $"{existingProduct.Name} updated";
db.SaveChanges();

// List<Product> products = db.Products.ToList();
var products = db.Products.ToList();
foreach (Product p in products)
{
    Console.WriteLine(p.Name);
}
