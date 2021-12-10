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

        [Route("product/create")]
        [HttpPost]
        public JsonResult Post(Product product)
        {
            if (ModelState.IsValid)
            {
                if (service.Post(product) > 0)
                {
                    return new JsonResult("Added one product successfully.");
                }

            }
            return new JsonResult("Cannot add new product.");
        }

        [Route("product/update/{id}")]
        [HttpPut]
        public JsonResult Put(int id, Product product)
        {
            if (ModelState.IsValid)
            {
                if (service.Put(id, product) > 0)
                    return new JsonResult("Updated product successfully.");
            }
            return new JsonResult("Cannot update product.");
        }

        [Route("product/{id}")]
        [HttpGet]
        public JsonResult GetProductById(int id)
        {

            Product product = service.GetProductById(id);
            return new JsonResult(product);

        }
        [Route("product/delete/{id}")]
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            if (service.Delete(id) > 0)
                return new JsonResult("Deleted product successfully.");

            return new JsonResult("Cannot delete product.");
        }
    }
}
