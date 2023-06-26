using CoffeeBook.Contracts;
using CoffeeBook.DataAccess;
using CoffeeBook.Models;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeBook.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly CoffeeBookDbContext _context;

        public SupplierService(CoffeeBookDbContext context)
        {
            _context = context;
        }

        public List<Supplier> GetAllSuppliers()
        {
            return _context.Suppliers.ToList();
        }

        public Supplier GetSupplierById(int id)
        {
            try
            {
                return _context.Suppliers.Find(id);
            }
            catch
            {
                return null;
            }
        }

        public int AddNewSupplier(Supplier supplier)
        {
            try
            {
                _context.Suppliers.Add(supplier);
                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }

        public int UpdateSupplier(int id, Supplier supplier)
        {
            try
            {
                Supplier sup = _context.Suppliers.Find(id);
                sup.Name = supplier.Name;
                sup.Phone = supplier.Phone;
                sup.Url = supplier.Url;
                sup.Country = supplier.Country;
                sup.City = supplier.City;
                sup.Description = supplier.Description;
                sup.Address = supplier.Address;
                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }

        public int DeleteSupplier(int id)
        {
            try
            {
                var deletedSupplier = _context.Suppliers.Find(id);
                _context.Suppliers.Remove(deletedSupplier);
                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }
    }
}