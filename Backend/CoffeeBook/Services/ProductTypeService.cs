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
        private readonly Context _context;

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
            _context = context;
        }

        public List<ProductType> FindAll()
        {
            return _context.ProductTypes.ToList();
        }

        public ProductType GetProductTypeById(int id)
        {
            return _context.ProductTypes.Single(s => s.Id == id);
        }

        public int Post(ProductType model)
        {
            _context.ProductTypes.Add(model);
            return _context.SaveChanges();
        }

        public int Put(int id, ProductType model)
        {
            var productType = _context.ProductTypes.Single(s => s.Id == id);
            productType.Name = model.Name;
            productType.Description = model.Description;
            return _context.SaveChanges();
        }

        public int Delete(int id)
        {
            var productType = _context.ProductTypes.Single(s => s.Id == id);
            _context.ProductTypes.Remove(productType);
            return _context.SaveChanges();
        }
    }
}
