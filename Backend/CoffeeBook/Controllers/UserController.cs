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
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly UserService service;

        public UserController(IConfiguration config)
        {
            _config = config;
            service = new UserService(_config);
        }


        [Route("user")]
        [HttpGet]
        public JsonResult Get()
        {
            /*NewsService service = new NewsService(_config);*/
            DataTable table = service.findAll();
            if (table.Equals("") || table == null || table.Rows.Count == 0)
                return new JsonResult("There is no data.");

            return new JsonResult(table);
        }

        [Route("user/add")]
        [HttpPost]
        public JsonResult Post(User user)
        {
            DataTable table = service.save(user);

            return new JsonResult("Added successfully!");
        }

        [Route("signin")]
        [HttpPost]
        public JsonResult Register(SigninDto dto)
        {
            DataTable table = service.Register(dto);

            return new JsonResult("Register successfully!");
        }

        [Route("user/edit")]
        [HttpPut]
        public JsonResult Put(User user)
        {
            DataTable table = service.update(user);

            return new JsonResult("Updated successfully!");
        }

        [Route("user/delete/{id}")]
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            DataTable table = service.deleteById(id);

            return new JsonResult($"User with id = {id} is deleted successfully!");
        }
    }
}
