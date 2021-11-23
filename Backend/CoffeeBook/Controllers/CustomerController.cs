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
    public class CustomerController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly CustomerService service;
        private readonly Context context;

        public CustomerController(IConfiguration config, Context ctx)
        {
            _config = config;
            context = ctx;
            service = new CustomerService(_config, ctx);
        }


        [Route("customer")]
        [HttpGet]
        public JsonResult Get()
        {
            /*NewsService service = new NewsService(_config);*/
            DataTable table = service.findAll();
            if (table.Equals("") || table == null || table.Rows.Count == 0)
                return new JsonResult("There is no data.");
            
            return new JsonResult(table);
        }

        [Route("customer/add")]
        [HttpPost]
        public JsonResult Post(Customer customer)
        {
            DataTable table = service.save(customer);

            return new JsonResult("Added successfully!");
        }

        [Route("authen/login")]
        [HttpPost]
        public JsonResult Login(SigninDto dto)
        {
            Customer table = service.Login(dto);

            if(table == null)
                return new JsonResult("Username or Password is invalid.");
            else
            {
                /*Customer result = new Customer();
                result.Username = table.Username;
                result.Id = table.Id;
                result.Name = table.Name;
                result.Phone = table.Phone;
                result.Address = table.Address;
                result.Avata = table.Avata;
                result.City = table.City;
                result.*/
                return new JsonResult(table);
            }
            /*if (table.Equals("") || table == null || table.Rows.Count == 0)
                return new JsonResult("Username or Password is invalid.");*/

            
        }

        [Route("signup")]
        [HttpPost]
        public JsonResult Register(SignupDto dto)
        {
            DataTable table = service.Register(dto);

            return new JsonResult("Register successfully!");
        }

        [Route("customer/edit")]
        [HttpPut]
        public JsonResult Put(Customer customer)
        {
            DataTable table = service.update(customer);

            return new JsonResult("Updated successfully!");
        }

        [Route("customer/delete/{id}")]
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            DataTable table = service.deleteById(id);

            return new JsonResult($"Customer with id = {id} is deleted successfully!");
        }
    }
}
