using CoffeeBook.Models;
using System.Collections.Generic;

namespace CoffeeBook.Contracts
{
    public interface IProductService
    {
        List<Product> GetAll();

        Product GetById(int id);

        int AddNewProduct(Product model);

        int UpdateProduct(int id, Product model);

        int DeleteProduct(int id);
    }
}