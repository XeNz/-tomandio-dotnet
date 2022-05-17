using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TomAndIO.Models.Entities;

namespace TomAndIO.Core.DAL;

public class ShoppingContext : IdentityDbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

    public string DbPath { get; }

    public ShoppingContext(DbContextOptions<ShoppingContext> options) : base(options)
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "shopping.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Product>().ToTable("Category");
        modelBuilder.Entity<Product>().ToTable("Product");
        modelBuilder.Entity<Product>().ToTable("ShoppingCart");
        modelBuilder.Entity<Product>().ToTable("ShoppingCartItem");

        modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany()
            .HasForeignKey("CategoryId")
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<ShoppingCartItem>()
            .HasOne(sci => sci.ShoppingCart)
            .WithMany()
            .HasForeignKey("ShoppingCartId")
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<ShoppingCartItem>()
            .HasOne(sci => sci.Product)
            .WithMany()
            .HasForeignKey("ProductId")
            .OnDelete(DeleteBehavior.NoAction);
    }
}