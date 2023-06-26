using CoffeeBook.Contracts;
using CoffeeBook.DataAccess;
using CoffeeBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeBook.Services
{
    public class ProductTypeService : IProductTypeService
    {
        private readonly CoffeeBookDbContext _context;

        public ProductTypeService(CoffeeBookDbContext context)
        {
            _context = context;
        }

        public List<ProductType> GetAllProductType()
        {
            return _context.ProductTypes.ToList();
        }

        public ProductType GetProductTypeById(int id)
        {
            try
            {
                return _context.ProductTypes.Find(id);
            }
            catch { return null; }
        }

        public int AddNewProductType(ProductType model)
        {
            try
            {
                _context.ProductTypes.Add(model);
                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }

        public int UpdateProductType(int id, ProductType model)
        {
            try
            {
                var productType = _context.ProductTypes.Find(id);
                productType.Name = model.Name;
                productType.Description = model.Description;
                productType.Photo = model.Photo;
                return _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }

        public int DeleteProductType(int id)
        {
            try
            {
                var productType = _context.ProductTypes.Find(id);
                _context.ProductTypes.Remove(productType);
                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }
    }
}