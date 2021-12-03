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
    //[Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly RoleService _service;
        private readonly Context _context;
        public RoleController(IConfiguration config, Context context)
        {
            _config = config;
            _context = context;
            _service = new RoleService(_config, _context);
        }
        [Route("role")]
        [HttpGet]
        public JsonResult Get()
        {
            var roleList = _service.GetAllRoles();
            return new JsonResult(roleList);
        }

        [Route("role/add")]
        [HttpPost]
        public JsonResult AddRole(Role role)
        {
            int result = _service.Post(role);
            if (result == 0)
                return new JsonResult("Added failed");
            return new JsonResult("Added successfully");
        }
    }
}
