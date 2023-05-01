using Layali.Models;
using Microsoft.EntityFrameworkCore;

namespace Layali.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public  DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "NameOfDress", DisplayOrder = 1 },
                new Category { Id = 2, Name = "NameOfDress", DisplayOrder = 2 },
                new Category { Id = 3, Name = "NameOfDress", DisplayOrder = 3 }

                );

            modelBuilder.Entity<Product>().HasData(

                new Product
                {
                    Id = 1,
                    Style = "Summer dress",
                    Description = "NEED SOME INFO HERE HUMAA BAJIII... . ",
                    Colour = "LightBlue",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 2,
                    Style = "Winter dress ",
                    Description = "NEED SOME INFO HERE HUMAA BAJIII... . ",
                    Colour = "Black",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Style = "Vanish in the Sunset",
                    Description = "NEED SOME INFO HERE HUMAA BAJIII... . ",
                    Colour = "Vanilla",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Style = "Abby Muscles",
                    Description = "NEED SOME INFO HERE HUMAA BAJIII... . ",
                    Colour = "Purple",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Style = "Ron Parker",
                    Description = "NEED SOME INFO HERE HUMAA BAJIII... . ",
                    Colour = "Green",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Style = "Laura Phantom",
                    Description = "NEED SOME INFO HERE HUMAA BAJIII... . ",
                    Colour = "Blue",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20,
                    CategoryId = 3,
                    ImageUrl = ""
                }
                );




        }
    }
}
