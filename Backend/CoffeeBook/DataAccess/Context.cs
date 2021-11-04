using CoffeeBook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBook.DataAccess
{
    public class Context : DbContext
    {
        // Test new connection method
        /*private readonly IConfiguration _config;
        private string connectionString;
        public Context(IConfiguration config)
        {
            _config = config;
            connectionString = _config.GetConnectionString("CoffeeBook");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(connectionString);
        }*/
        public Context(DbContextOptions<Context> options): base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
