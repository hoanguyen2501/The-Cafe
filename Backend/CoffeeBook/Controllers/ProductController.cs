using CoffeeBook.DataAccess;
using CoffeeBook.Models;
using CoffeeBook.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBook.Controllers
{
    /*[Route("api/[controller]")]*/
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly ProductService service;
        private readonly Context context;

        public ProductController(IConfiguration config, Context ctx)
        {
            _config = config;
            context = ctx;
            service = new ProductService(_config, context);
        }

        [Route("products")]
        [HttpGet]
        public JsonResult Get()
        {
            List<Product> table = service.FindAll();
            if (table == null)
                return new JsonResult("There is no data");


            return new JsonResult(table);
        }

        [Route("product/delete/{id}")]
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            DataTable table = service.deleteById(id);

            return new JsonResult($"Product with id = {id} is deleted successfully!");
        }

    }
}
