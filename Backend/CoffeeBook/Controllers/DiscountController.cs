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
    public class DiscountController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly DiscountService service;

        public DiscountController(IConfiguration config)
        {
            _config = config;
            service = new DiscountService(_config);
        }


        [Route("discount")]
        [HttpGet]
        public JsonResult Get()
        {
            /*NewsService service = new NewsService(_config);*/
            DataTable table = service.findAll();
            if (table.Equals("") || table == null || table.Rows.Count == 0)
                return new JsonResult("There is no data.");

            return new JsonResult(table);
        }

        [Route("discount/add")]
        [HttpPost]
        public JsonResult Post(Discount discount)
        {
            DataTable table = service.save(discount);

            return new JsonResult("Added successfully!");
        }

        [Route("discount/edit")]
        [HttpPut]
        public JsonResult Put(Discount discount)
        {
            DataTable table = service.update(discount);

            return new JsonResult("Updated successfully!");
        }

        [Route("discount/delete/{id}")]
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            DataTable table = service.deleteById(id);

            return new JsonResult($"Discount with id = {id} is deleted successfully!");
        }
    }
}
