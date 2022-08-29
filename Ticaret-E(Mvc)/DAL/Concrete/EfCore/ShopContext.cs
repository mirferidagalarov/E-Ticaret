using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using Ticaret_E_Mvc_.Entities;

namespace Ticaret_E_Mvc_.Concrete.EfCore
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         

            modelBuilder.Entity<ProductCategory>()
       .HasKey(bc => new { bc.CategoryId, bc.ProductId });
            modelBuilder.Entity<ProductCategory>()
                .HasOne(bc => bc.Category)
                .WithMany(b => b.ProductCategories)
                .HasForeignKey(bc => bc.CategoryId);
            modelBuilder.Entity<ProductCategory>()
                .HasOne(bc => bc.Product)
                .WithMany(c => c.ProductCategories)
                .HasForeignKey(bc => bc.ProductId);
        }

    }
}
