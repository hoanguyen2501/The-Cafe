using CoffeeBook.DataAccess;
using CoffeeBook.Dto;
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
    public class AccountController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AccountService _service;
        private readonly Context context;

        public AccountController(IConfiguration config, Context ctx)
        {
            _config = config;
            context = ctx;
            _service = new AccountService(_config, ctx);
        }


        [Route("admin/login")]
        [HttpPost]
        public JsonResult Login(AdminLoginDto dto)
        {
            Account result = _service.Login(dto);

            if(result == null)
            {
                return new JsonResult("Username or Password is invalid.");
            }
            return new JsonResult(result);
        }
    }
}
