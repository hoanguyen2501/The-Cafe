using CoffeeBook.Models;
using System.Collections.Generic;

namespace CoffeeBook.Contracts
{
    public interface IDiscountService
    {
        List<Discount> GetAllDiscounts();

        Discount GetDiscountById(int id);

        int AddNewDiscount(Discount discount);

        int UpdateDiscount(int id, Discount discount);

        int DeleteDiscount(int id);
    }
}