using CoffeeBook.DataAccess;
using CoffeeBook.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBook.Services
{
    public class ManagerService
    {
        private readonly IConfiguration _config;
        private readonly string sqlDatasource;
        private readonly Context _context;
        public ManagerService() { }
        public ManagerService(IConfiguration config)
        {
            _config = config;
            sqlDatasource = _config.GetConnectionString("CoffeeBook");
        }
        public ManagerService(IConfiguration config, Context context)
        {
            _config = config;
            _context = context;
            sqlDatasource = _config.GetConnectionString("CoffeeBook");
        }

        public List<Manager> GetAllManagers()
        {
            return _context.Managers.ToList();
        }

        public Manager GetManagerById(int id)
        {
            try
            {
                return _context.Managers.Single(s => s.Id == id);
            }
            catch
            {
                return null;
            }
        }

        public int Post(Manager model)
        {
            try
            {
                Console.WriteLine(model.StoreId);
                _context.Managers.Add(model);
                var result = _context.SaveChanges();
                // nếu có set storeId thì sẽ set managerId bên Store
                if (model.StoreId != null && model.StoreId != 0)
                {
                    var store = _context.Stores.Single(s => s.Id == model.StoreId);
                    var manager = _context.Managers.Single(s => s.Email == model.Email && s.Phone == model.Phone);
                    store.ManagerId = manager.Id;
                    _context.SaveChanges();
                }
                return result;
            }
            catch
            {
                return -1;
            }
        }

        public List<Manager> GetManagerWithoutStore()
        {
            List<Manager> managers = _context.Managers.Where(w => string.IsNullOrEmpty(w.StoreId.ToString()) || w.StoreId == 0).ToList();
            return managers;
        }

        public int Put(int id, Manager model)
        {
            try
            {
                var manager = _context.Managers.Single(s => s.Id == id);
                manager.Name = model.Name;
                manager.Age = model.Age;
                manager.Gender = model.Gender;
                manager.Address = model.Address;
                manager.City = model.City;
                manager.Country = model.Country;
                manager.Email = model.Email;
                manager.Phone = model.Phone;
                manager.Salary = model.Salary;
                manager.Status = model.Status;
                manager.StoreId = model.StoreId;
                manager.Bonus = model.Bonus;

                var result = _context.SaveChanges();

                if (manager.StoreId != null)
                {
                    // setnull manager trùng storeId
                    var listStores = _context.Stores.Where(w => w.ManagerId == id && w.Id != model.StoreId).ToList();
                    foreach (var item in listStores)
                    {
                        item.ManagerId = null;
                    }

                    // nếu có set storeId thì sẽ set managerId bên Store
                    var store = _context.Stores.Single(s => s.Id == manager.StoreId);
                    store.ManagerId = id;
                    _context.SaveChanges();
                }
                return result;
            }
            catch
            {
                return -1;
            }
        }

        public List<Manager> GetManagerWithoutAcc()
        {
            List<Manager> managers = _context.Managers.Where(w=> string.IsNullOrEmpty(w.AccountId.ToString())).ToList();
            return managers;
        }

        public int Delete(int id)
        {
            try
            {
                var manager = _context.Managers.Single(s => s.Id == id);
                _context.Managers.Remove(manager);
                var result = _context.SaveChanges();
                return result;
            }
            catch
            {
                return -1;
            }
        }
    }
}
