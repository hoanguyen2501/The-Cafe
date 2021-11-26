using CoffeeBook.DataAccess;
using CoffeeBook.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBook.Services
{
    public class RoleService
    {
        private readonly IConfiguration _config;
        private readonly string connectionStr;
        private readonly Context _context;
        public RoleService(IConfiguration config, Context context)
        {
            _config = config;
            connectionStr = _config.GetConnectionString("CoffeeBook");
            _context = context;
        }

        public List<Role> GetAllRoles()
        {
            var roles = _context.Roles.ToList();
            return roles;
        }

        public Role GetRoleById(int id)
        {
            return _context.Roles.Single(s => s.Id == id);
        }

        public int Post(Role model)
        {
            _context.Roles.Add(model);
            return _context.SaveChanges();
        }

        public int Put(int id, Role model)
        {
            var role = _context.Roles.Single(s => s.Id == id);

                role.RoleName = model.RoleName;
                role.Description = model.Description;
                var result = _context.SaveChanges();

            return result;
           
        }

        public int Delete(int id)
        {
            var role = _context.Roles.Single(s => s.Id == id);
            _context.Roles.Remove(role);
            return _context.SaveChanges();
        }
    }
}
