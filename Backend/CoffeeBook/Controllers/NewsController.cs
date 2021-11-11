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
    public class NewsController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly NewsService service;

        public NewsController(IConfiguration config)
        {
            _config = config;
            service = new NewsService(_config);
        }


        [Route("news")]
        [HttpGet]
        public JsonResult Get()
        {
            /*NewsService service = new NewsService(_config);*/
            DataTable table = service.findAll();
            if (table.Equals("") || table == null || table.Rows.Count == 0)
                return new JsonResult("There is no data.");

            return new JsonResult(table);
        }

        [Route("news/add")]
        [HttpPost]
        public JsonResult Post(News news)
        {
            DataTable table = service.save(news);
            
            return new JsonResult("Added successfully!");
        }

        [Route("news/edit")]
        [HttpPut]
        public JsonResult Put(News news)
        {
            DataTable table = service.update(news);

            return new JsonResult("Updated successfully!");
        }

        [Route("news/delete/{id}")]
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            DataTable table = service.deleteById(id);

            return new JsonResult($"News with id = {id} is deleted successfully!");
        }
    }
}
