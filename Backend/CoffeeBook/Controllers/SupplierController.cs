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
    public class SupplierController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly SupplierService service;

        public SupplierController(IConfiguration config)
        {
            _config = config;
            service = new SupplierService(_config);
        }


        [Route("supplier")]
        [HttpGet]
        public JsonResult Get()
        {
            /*NewsService service = new NewsService(_config);*/
            DataTable table = service.findAll();
            if (table.Equals("") || table == null || table.Rows.Count == 0)
                return new JsonResult("There is no data.");

            return new JsonResult(table);
        }

        [Route("supplier/add")]
        [HttpPost]
        public JsonResult Post(Supplier supplier)
        {
            DataTable table = service.save(supplier);

            return new JsonResult("Added successfully!");
        }

        [Route("supplier/edit")]
        [HttpPut]
        public JsonResult Put(Supplier supplier)
        {
            DataTable table = service.update(supplier);

            return new JsonResult("Updated successfully!");
        }

        [Route("supplier/delete/{id}")]
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            DataTable table = service.deleteById(id);

            return new JsonResult($"Supplier with id = {id} is deleted successfully!");
        }
    }
}
