using CoffeeBook.DataAccess;
using CoffeeBook.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBook.Services
{
    public class StoreService
    {
        private readonly IConfiguration _config;
        private readonly string sqlDatasource;
        private readonly Context _context;

        public StoreService() { }
        public StoreService(IConfiguration config)
        {
            _config = config;
            sqlDatasource = _config.GetConnectionString("CoffeeBook");
        }
        public StoreService(IConfiguration config, Context context)
        {
            _config = config;
            sqlDatasource = _config.GetConnectionString("CoffeeBook");
            _context = context;
        }

        public List<Store> GetAllStores()
        {
            return _context.Stores.ToList();
        }

        public Manager GetManager(int id)
        {
            var manager = _context.Managers.Single(w => w.AccountId == id);
            return manager;
        }
        public List<Store> GetAllStoreByManager(Manager manager)
        {
            if (manager.StoreId == null) return null;
            List<Store> stores = _context.Stores.Where(w => w.Id == manager.StoreId).ToList();
            return stores;
        }

        public Store GetStoreById(int id)
        {
            try
            {
                return _context.Stores.Single(s=>s.Id == id);
            }
            catch
            {
                return null;
            }
        }

        public IQueryable GetByDistrict()
        {
            var query = from s in _context.Stores
                        group s by new { District = s.District} into k
                        select new { Count = k.Count(), District = k.Key.District };

            return query;
        }
        public int Post(Store model)
        {
            try
            {
                _context.Stores.Add(model);
                var resutl = _context.SaveChanges();
                return resutl;
            }
            catch
            {
                return -1;
            }
        }

        public List<Store> GetStoreWithoutManager(int id)
        {
            var stores = _context.Stores.Where(w => string.IsNullOrEmpty(w.ManagerId.ToString()) || w.ManagerId == id).ToList();
            stores.Add(new Store());
            return stores;
        }

        public int Put(int id, Store model)
        {
            try
            {
                var store = _context.Stores.Single(s => s.Id == id);
                store.StoreName = model.StoreName;
                store.Description = model.Description;
                store.Address = model.Address;
                store.Country = model.Country;
                store.Phone = model.Phone;
                store.Photo = model.Photo;
                store.LinkGG = model.LinkGG;
                store.District = model.District;
                store.ManagerId = model.ManagerId;

                var res = _context.SaveChanges();

                if(store.ManagerId != null)
                {
                    // setnull manager trùng storeId
                    var listManager = _context.Managers.Where(w => w.StoreId == id && w.Id != model.ManagerId).ToList();
                    foreach(var item in listManager)
                    {
                        item.StoreId = null;
                    }

                    // set 2 chiều
                    var manager = _context.Managers.Single(s => s.Id == model.ManagerId);
                    manager.StoreId = id;

                    _context.SaveChanges();
                }

                return res;
            }
            catch
            {
                return -1;
            }

        }

        public int Delete(int id)
        {
            try
            {
                var store = _context.Stores.Single(s => s.Id == id);
                _context.Stores.Remove(store);

                var resulut = _context.SaveChanges();
                return resulut;
            }
            catch
            {
                return -1;
            }
        }
    }
}
