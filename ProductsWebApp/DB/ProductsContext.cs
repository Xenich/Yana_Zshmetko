using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsWebApp.DB
{
    public class ProductsContext : DbContext
    {
        public ProductsContext()           
        {
            Database.EnsureCreated();           
        }

        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category[]
                {
                    new Category { Id = 1,  Name="Категория 1", Alias = "FIRST"},
                    new Category { Id = 2,  Name="Категория 2", Alias = "SECOND"},
                    new Category { Id = 3,  Name="Категория 3", Alias = "THIRD"}
                });
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
