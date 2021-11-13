using CoffeeBook.DataAccess;
using CoffeeBook.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBook.Controllers
{
    /*[Route("api/[controller]")]*/
    [ApiController]
    public class ProductTypeController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly ProductTypeService service;
        private readonly Context context;

        public ProductTypeController(IConfiguration config, Context ctx)
        {
            _config = config;
            context = ctx;
            service = new ProductTypeService(_config);
        }
    }
}
