using CoffeeBook.Contracts;
using CoffeeBook.DataAccess;
using CoffeeBook.Models;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeBook.Services
{
    public class StoreService : IStoreService
    {
        private readonly CoffeeBookDbContext _context;

        public StoreService(CoffeeBookDbContext context)
        {
            _context = context;
        }

        public List<Store> GetAllStores()
        {
            return _context.Stores.ToList();
        }

        public Store GetStoreById(int id)
        {
            try
            {
                return _context.Stores.Find(id);
            }
            catch
            {
                return null;
            }
        }

        public IQueryable GetByDistrict()
        {
            var query = _context.Stores.GroupBy(g => g.District)
                                    .Select(group =>
                                    new
                                    {
                                        District = group.Key,
                                        Count = group.Count()
                                    })
                                    .OrderByDescending(o => o.Count)
                                    .AsQueryable();
            return query;
        }

        public int AddNewStore(Store model)
        {
            try
            {
                _context.Stores.Add(model);
                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }

        public int UpdateStore(int id, Store model)
        {
            try
            {
                var store = _context.Stores.Find(id);
                store.StoreName = model.StoreName;
                store.Description = model.Description;
                store.Address = model.Address;
                store.Country = model.Country;
                store.Phone = model.Phone;
                store.Photo = model.Photo;
                store.LinkGG = model.LinkGG;
                store.District = model.District;
                store.ManagerId = model.ManagerId;

                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }

        public int DeleteStore(int id)
        {
            try
            {
                var store = _context.Stores.Find(id);
                _context.Stores.Remove(store);

                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }
    }
}