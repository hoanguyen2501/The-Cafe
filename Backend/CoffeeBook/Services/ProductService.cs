using CoffeeBook.Contracts;
using CoffeeBook.DataAccess;
using CoffeeBook.Models;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeBook.Services
{
    public class ProductService : IProductService
    {
        private readonly CoffeeBookDbContext _context;

        public ProductService(CoffeeBookDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAll() => _context.Products.ToList();

        public Product GetById(int id) => _context.Products.Find(id);

        public int AddNewProduct(Product model)
        {
            try
            {
                _context.Products.Add(model);
                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }

        public int UpdateProduct(int id, Product model)
        {
            try
            {
                var product = _context.Products.Find(id);

                product.CreatedDate = model.CreatedDate;
                product.Description = model.Description; product.Name = model.Name;
                product.Photo = model.Photo;
                product.Price = model.Price;
                product.Size = model.Size;
                product.ProductTypeId = model.ProductTypeId;
                product.SupplierId = model.SupplierId;

                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }

        public int DeleteProduct(int id)
        {
            try
            {
                var product = _context.Products.Find(id);
                _context.Products.Remove(product);
                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }
    }
}