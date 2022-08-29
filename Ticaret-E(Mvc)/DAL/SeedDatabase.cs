using Microsoft.EntityFrameworkCore;
using Ticaret_E_Mvc_.Concrete.EfCore;
using Ticaret_E_Mvc_.Entities;

namespace Ticaret_E_Mvc_.DAL
{
    public static class SeedDatabase
    {

        public static void Seed(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasData(
            new Category() { Name = "Telefon" },
            new Category() { Name = "Komputer" },
            new Category() { Name = "Elektronika" }

            );
            modelBuilder.Entity<Product>().HasData(

                new Product() { Name = "Iphone", Price = 2000, ImageUrl = "1.jpg",IsApproved = true },
                new Product() { Name = "Iphone", Price = 2000, ImageUrl = "1.jpg",IsApproved=true},
                new Product() { Name = "Iphone", Price = 2000, ImageUrl = "1.jpg",IsApproved = true }

                ); ;
        }
    }
}

