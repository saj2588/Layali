﻿using Layali.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Layali.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "NameOfDress", DisplayOrder = 1 },
                new Category { Id = 2, Name = "NameOfDress", DisplayOrder = 2 },
                new Category { Id = 3, Name = "NameOfDress", DisplayOrder = 3 }

                );

            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Valencia International", StreetAddress = "123 norway", City = "Doha", PostCode = "ig38bb", State = "Qatar", PhoneNumber = "457854" },
                new Company { Id = 2, Name = "Technology Services", StreetAddress = "575 jhelum", City = "Doha", PostCode = "ig38bb", State = "Qatar", PhoneNumber = "457854" },
                new Company { Id = 3, Name = "Bakery Ingredients", StreetAddress = "778 dubai", City = "Doha", PostCode = "ig38bb", State = "Qatar", PhoneNumber = "457854" }

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
                    ImageUrl = ""
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
