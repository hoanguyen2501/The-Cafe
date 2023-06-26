using CoffeeBook.Models;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeBook.Contracts
{
    public interface IStoreService
    {
        List<Store> GetAllStores();

        Store GetStoreById(int id);

        IQueryable GetByDistrict();

        int AddNewStore(Store model);

        int UpdateStore(int id, Store model);

        int DeleteStore(int id);
    }
}