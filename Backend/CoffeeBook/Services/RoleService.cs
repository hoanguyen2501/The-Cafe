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

        public List<Role> GetAllRole()
        {
            var roles = _context.Roles.ToList();
            return roles;
        }
    }
}
