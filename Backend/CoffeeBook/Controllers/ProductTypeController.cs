using CoffeeBook.DataAccess;
using CoffeeBook.Models;
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
            service = new ProductTypeService(_config, context);
        }

        [Route("ProductTypes")]
        [HttpGet]
        public JsonResult Get()
        {
            List<ProductType> table = service.FindAll();
            if (table == null)
                return new JsonResult("There is no data");


            return new JsonResult(table);
        }

        [Route("ProductType/create")]
        [HttpPost]
        public JsonResult Post(ProductType productType)
        {
            if (ModelState.IsValid)
            {
                if (service.Post(productType) > 0)
                {
                    return new JsonResult("Added one product type successfully.");
                }

            }
            return new JsonResult("Cannot add new product type.");
        }

        [Route("ProductType/update/{id}")]
        [HttpPut]
        public JsonResult Put(int id, ProductType productType)
        {
            if (ModelState.IsValid)
            {
                if (service.Put(id, productType) > 0)
                    return new JsonResult("Updated product type successfully.");
            }
            return new JsonResult("Cannot update type product.");
        }

        [Route("ProductType/delete/{id}")]
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            if (service.Delete(id) > 0)
                return new JsonResult("Deleted product type successfully.");

            return new JsonResult("Cannot delete type product.");
        }
    }
}
