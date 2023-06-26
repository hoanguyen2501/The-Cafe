using CoffeeBook.Models;
using System.Collections.Generic;

namespace CoffeeBook.Contracts
{
    public interface IProductTypeService
    {
        List<ProductType> GetAllProductType();

        ProductType GetProductTypeById(int id);

        int AddNewProductType(ProductType model);

        int UpdateProductType(int id, ProductType model);

        int DeleteProductType(int id);
    }
}