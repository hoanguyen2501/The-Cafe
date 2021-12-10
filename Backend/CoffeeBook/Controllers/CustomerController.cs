using CoffeeBook.Authen;
using CoffeeBook.DataAccess;
using CoffeeBook.Dto;
using CoffeeBook.Models;
using CoffeeBook.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
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
        private readonly AppSetting _appSettings;

        public CustomerController(IConfiguration config, Context ctx, IOptions<AppSetting> appSettings)
        {
            _config = config;
            context = ctx;
            _appSettings = appSettings.Value;
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

        [Route("customer/{id}")]
        [HttpGet]
        public ActionResult GetById(int id)
        {
            Customer list = service.findById(id);
            if (list == null) return BadRequest();
            return new JsonResult(list);
        }

        [Route("customer/add")]
        [HttpPost]
        public JsonResult Post(Customer customer)
        {
            DataTable table = service.save(customer);

            return new JsonResult("Added successfully!");
        }

        [Route("customer/login")]
        [HttpPost]
        public ActionResult Login(SigninDto dto)
        {
            Customer user = service.Login(dto);

            if(user == null)
                return BadRequest();

            var token = generateJwtToken(user);

            return new JsonResult(new { Token = token });
        }

        [Route("customer/signup")]
        [HttpPost]
        public JsonResult Register(SignupDto dto)
        {
            DataTable table = service.Register(dto);

            return new JsonResult("Register successfully!");
        }

        [Route("customer/edit/{id}")]
        [HttpPut]
        public ActionResult Put(int id,Customer customer)
        {
            int res = service.update(id,customer);
            if (res > 0) return Ok();
            else return BadRequest();
        }

        [Route("customer/delete/{id}")]
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            DataTable table = service.deleteById(id);

            return new JsonResult($"Customer with id = {id} is deleted successfully!");
        }


        private string generateJwtToken(Customer customer)
        {
            var claims = new Claim[]
            {
                new Claim("Id", customer.Id.ToString()),
                new Claim("Username", customer.Username),
                new Claim(ClaimTypes.Email, customer.Email)
            };

            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddSeconds(20),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
