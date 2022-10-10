using CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System;

namespace Plugins.DataStore.SQL
{
    public class MarketContext : DbContext
    {
        public MarketContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            //seeding algo de data
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Panaderia", Description = "Vende panes, Galletitas" },
                new Category { CategoryId = 2, Name = "Carniceria", Description = "Vende cortes de carne" },
                new Category { CategoryId = 3, Name = "Electronica", Description = "Vende productos de electro" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, CategoryId = 1, Name = "Te helado", Quantity = 100, Price = 1.99 },
                new Product { ProductId = 2, CategoryId = 1, Name = "Te Canadiense", Quantity = 200, Price = 2.99 },
                new Product { ProductId = 3, CategoryId = 2, Name = "Bife ancho", Quantity = 300, Price = 4.99 },
                new Product { ProductId = 4, CategoryId = 2, Name = "Bife angosto", Quantity = 200, Price = 4 }
            );
        }
    }
}
