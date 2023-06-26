using CoffeeBook.Extensions;
using CoffeeBook.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeBook.DataAccess
{
    public class CoffeeBookDbContext : DbContext
    {
        public CoffeeBookDbContext(DbContextOptions<CoffeeBookDbContext> options) : base(options)
        { }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ShoppingCart_Product> ShoppingCart_Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply Model Configuration
            modelBuilder.ApplyModelConfiguration();

            // Data Seeding
            modelBuilder.Seed();
        }
    }
}