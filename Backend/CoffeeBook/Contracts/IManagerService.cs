using CoffeeBook.Models;
using System.Collections.Generic;

namespace CoffeeBook.Contracts
{
    public interface IManagerService
    {
        List<Manager> GetAllManagers();

        Manager GetManagerById(int id);

        int AddNewManager(Manager model);

        int UpdateManager(int id, Manager model);

        int DeleteManager(int id);
    }
}