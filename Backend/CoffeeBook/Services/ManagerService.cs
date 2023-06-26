using CoffeeBook.Contracts;
using CoffeeBook.DataAccess;
using CoffeeBook.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeBook.Services
{
    public class ManagerService : IManagerService
    {
        private readonly CoffeeBookDbContext _context;

        public ManagerService(CoffeeBookDbContext context)
        {
            _context = context;
        }

        public List<Manager> GetAllManagers()
        {
            return _context.Managers.Include(i => i.Store).ToList();
        }

        public Manager GetManagerById(int id)
        {
            try
            {
                return _context.Managers.Find(id);
            }
            catch
            {
                return null;
            }
        }

        public int AddNewManager(Manager model)
        {
            try
            {
                _context.Managers.Add(model);
                var result = _context.SaveChanges();
                return result;
            }
            catch
            {
                return -1;
            }
        }

        public int UpdateManager(int id, Manager model)
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

                var result = _context.SaveChanges();
                return result;
            }
            catch
            {
                return -1;
            }
        }

        public int DeleteManager(int id)
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