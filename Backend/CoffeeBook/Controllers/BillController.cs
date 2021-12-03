using CoffeeBook.DataAccess;
using CoffeeBook.Dto;
using CoffeeBook.Models;
using CoffeeBook.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBook.Controllers
{
    /*[Route("api/[controller]")]*/
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly Context context;
        private readonly BillService _service;
        public BillController(IConfiguration config, Context ctx)
        {
            _config = config;
            context = ctx;
            _service = new BillService(_config, ctx);
            
        }

        [Route("bill")]
        [HttpGet]
        public JsonResult Get()
        {
            IQueryable table = _service.findAll();
            if (table.Equals("") || table == null)
                return new JsonResult("There is no data.");

            return new JsonResult(table);
        }

        [Route("bill/add")]
        [HttpPost]
        public JsonResult Post(Bill bill)
        {
            DataTable table = _service.save(bill);

            return new JsonResult("Added successfully.");
        }

        [Route("bill/edit")]
        [HttpPut]
        public JsonResult Put(Bill bill)
        {
            DataTable table = _service.update(bill);

            return new JsonResult("Updated successfully.");
        }

        [Route("bill/delete/{id}")]
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            DataTable table = _service.DeleteById(id);

            return new JsonResult($"Bill {id} is Deleted successfully.");
        }

        [Route("bill/purchase")]
        [HttpPost]
        public JsonResult Purchase(BillDto dto)
        {
            int result = _service.Purchase(dto);
            if (result >= 1)
                return new JsonResult("Purchased successfully");

            return new JsonResult("Purchase Failed");
        }
    }
}
