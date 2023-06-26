using CoffeeBook.Contracts;
using CoffeeBook.DataAccess;
using CoffeeBook.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CoffeeBook.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly CoffeeBookDbContext _context;

        public DiscountService(CoffeeBookDbContext context)
        {
            _context = context;
        }

        public List<Discount> GetAllDiscounts()
        {
            return _context.Discounts.Where(w => w.Quantity > 0).ToList();
        }

        public Discount GetDiscountById(int id)
        {
            try
            {
                return _context.Discounts.Find(id);
            }
            catch
            {
                return null;
            }
        }

        public int AddNewDiscount(Discount discount)
        {
            try
            {
                _context.Discounts.Add(discount);
                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }

        public int DeleteDiscount(int id)
        {
            try
            {
                var deletedDiscount = _context.Discounts.Find(id);
                _context.Discounts.Remove(deletedDiscount);
                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }

        public int UpdateDiscount(int id, Discount discount)
        {
            try
            {
                var updatedDiscount = _context.Discounts.Find(id);
                updatedDiscount.Name = discount.Name;
                updatedDiscount.Photo = discount.Photo;
                updatedDiscount.Quantity = discount.Quantity;
                updatedDiscount.Value = discount.Value;
                updatedDiscount.ExpiredDate = discount.ExpiredDate;
                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }
    }
}