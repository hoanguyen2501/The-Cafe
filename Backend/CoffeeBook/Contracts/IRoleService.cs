using CoffeeBook.Models;
using System.Collections.Generic;

namespace CoffeeBook.Contracts
{
    public interface IRoleService
    {
        List<Role> GetAllRoles();

        Role GetRoleById(int id);

        int AddNewRole(Role model);

        int UpdateRole(int id, Role model);

        int DeleteRole(int id);
    }
}