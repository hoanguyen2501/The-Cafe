using CoffeeBook.DataAccess;
using CoffeeBook.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBook.Services
{
    public class ProductTypeService
    {
        private readonly IConfiguration _config;
        private readonly string sqlDataSource;
        private readonly Context ctx;

        public ProductTypeService()
        {
        }

        public ProductTypeService(IConfiguration config)
        {
            _config = config;
            sqlDataSource = _config.GetConnectionString("CoffeeBook");
        }

        public ProductTypeService(IConfiguration config, Context context)
        {
            _config = config;
            sqlDataSource = _config.GetConnectionString("CoffeeBook");
            ctx = context;
        }

        public List<ProductType> FindAll()
        {
            var query = from p in ctx.ProductTypes
                        select p;
            return query.ToList<ProductType>();
        }
    }
}
