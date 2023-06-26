using CoffeeBook.Models;
using System.Collections.Generic;

namespace CoffeeBook.Contracts
{
    public interface ISupplierService
    {
        List<Supplier> GetAllSuppliers();

        Supplier GetSupplierById(int id);

        int AddNewSupplier(Supplier supplier);

        int UpdateSupplier(int id, Supplier supplier);

        int DeleteSupplier(int id);
    }
}