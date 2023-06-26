using CoffeeBook.Contracts;
using CoffeeBook.DataAccess;
using CoffeeBook.Models;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeBook.Services
{
    public class RoleService : IRoleService
    {
        private readonly CoffeeBookDbContext _context;

        public RoleService(CoffeeBookDbContext context)
        {
            _context = context;
        }

        public List<Role> GetAllRoles()
        {
            return _context.Roles.ToList();
        }

        public Role GetRoleById(int id)
        {
            try
            {
                return _context.Roles.Find(id);
            }
            catch
            {
                return null;
            }
        }

        public int AddNewRole(Role model)
        {
            try
            {
                _context.Roles.Add(model);
                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }

        public int UpdateRole(int id, Role model)
        {
            try
            {
                var role = _context.Roles.Find(id);

                role.RoleName = model.RoleName;
                role.Description = model.Description;
                var result = _context.SaveChanges();

                return result;
            }
            catch
            {
                return -1;
            }
        }

        public int DeleteRole(int id)
        {
            try
            {
                var role = _context.Roles.Find(id);
                _context.Roles.Remove(role);
                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }
    }
}