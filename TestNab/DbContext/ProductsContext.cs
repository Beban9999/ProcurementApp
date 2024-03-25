using Microsoft.EntityFrameworkCore;

namespace TestNab.Models;

public class ProductsContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    public DbSet<ProductCategory> ProductCategories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=products.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "Pileca salata" },
            new Category { CategoryId = 2, Name = "Pica" },
            new Category { CategoryId = 3, Name = "Sendvic" },
            new Category { CategoryId = 4, Name = "Supa" });

        modelBuilder.Entity<Product>().HasData(
            new Product { ProductId = 1, Name = "Jaja", Merchant= "Zoran" },
            new Product { ProductId = 2, Name = "Majonez", Merchant = "Jovan" },
            new Product { ProductId = 3, Name = "Piletina", Merchant = "Zoran" },
            new Product { ProductId = 4, Name = "Sir", Merchant = "Zoran" },
            new Product { ProductId = 5, Name = "Mleko" , Merchant = "Jovan" },
            new Product { ProductId = 6, Name = "Govedina" , Merchant = "Zoran" },
            new Product { ProductId = 7, Name = "Junetina" , Merchant = "Ivan" },
            new Product { ProductId = 8, Name = "Kecap" , Merchant = "Zoran" },
            new Product { ProductId = 9, Name = "Makarone" , Merchant = "Ivan" },
            new Product { ProductId = 10, Name = "Krompir" , Merchant = "Zoran" });
    }
}