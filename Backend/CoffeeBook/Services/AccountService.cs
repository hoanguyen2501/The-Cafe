using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBook.Services
{
    public class AccountService
    {
        private readonly IConfiguration _config;
        private readonly string sqlDataSource;

        public AccountService()
        {
        }
        public AccountService(IConfiguration config)
        {
            _config = config;
            sqlDataSource = _config.GetConnectionString("CoffeeBook");
        }
    }
}
