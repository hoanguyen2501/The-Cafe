using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBook.Services
{
    public class ProductTypeService
    {
        private readonly IConfiguration _config;
        private readonly string sqlDataSource;

        public ProductTypeService()
        {
        }

        public ProductTypeService(IConfiguration config)
        {
            _config = config;
            sqlDataSource = _config.GetConnectionString("CoffeeBook");
        }
    }
}
