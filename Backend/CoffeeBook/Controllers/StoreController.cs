using CoffeeBook.DataAccess;
using CoffeeBook.Models;
using CoffeeBook.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBook.Controllers
{
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly StoreService service;
        private readonly Context context;
        public StoreController(IConfiguration config, Context ctx)
        {
            _config = config;
            context = ctx;
            service = new StoreService(_config, context);
        }

        [Route("stores")]
        [HttpGet]
        public ActionResult Get()
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var Role = getCurrentRole(jwt);
                if (Role == "2")
                {
                    var id = getCurrentAccountId(jwt);
                    Manager manager = service.GetManager(int.Parse(id));
                    var employees = service.GetAllStoreByManager(manager);
                    return new JsonResult(employees);
                }
                else if (Role == "1")
                {
                    var employees = service.GetAllStores();
                    return new JsonResult(employees);
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }
        [Route("stores/customer")]
        [HttpGet]
        public ActionResult GetCustomerStore()
        {
            var employees = service.GetAllStores();
            return new JsonResult(employees);
        }

        [Route("stores/withoutmanager/{id}")]
        [HttpGet]
        public ActionResult GetWithoutManager(int id)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var Role = getCurrentRole(jwt);
                if (Role == "1")
                {
                    List<Store> stores = service.GetStoreWithoutManager(id);
                    return new JsonResult(stores);
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }

        [Route("stores/district")]
        [HttpGet]
        public ActionResult GetByDistrict()
        {
            var stores = service.GetByDistrict();
            return new JsonResult(stores);
        }

        [Route("store/{id}")]
        [HttpGet]
        public ActionResult GetById(int id)
        {
            var store = service.GetStoreById(id);
            if (store == null) return BadRequest();
            return new JsonResult(store);
        }

        [Route("store/create")]
        [HttpPost]
        public ActionResult Post(Store store)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var Role = getCurrentRole(jwt);
                if (Role == "1" || Role == "2")
                {
                    if (ModelState.IsValid)
                    {
                        if (service.Post(store) > 0)
                        {
                            return Ok();
                        }
                    }
                    return BadRequest();
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }

        [Route("store/update/{id}")]
        [HttpPut]
        public ActionResult Put(int id, Store store)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var Role = getCurrentRole(jwt);
                if (Role == "1" || Role == "2")
                {
                    if (ModelState.IsValid)
                    {
                        if (service.Put(id, store) >= 0)
                            return Ok();
                    }
                    return BadRequest();
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }

        [Route("store/delete/{id}")]
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var Role = getCurrentRole(jwt);
                if (Role == "1" || Role == "2")
                {
                    if (service.Delete(id) > 0)
                        return Ok();

                    return BadRequest();
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }

        private string getCurrentRole(string jwt)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(jwt);
            var tokenS = jsonToken as JwtSecurityToken;
            var role = tokenS.Claims.First(claim => claim.Type == "RoleId").Value;
            return role;
        }

        private string getCurrentAccountId(string jwt)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(jwt);
            var tokenS = jsonToken as JwtSecurityToken;
            var id = tokenS.Claims.First(claim => claim.Type == "Id").Value;
            return id;
        }
        private string getCustomerRole(string jwtCustomer)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(jwtCustomer);
            var tokenS = jsonToken as JwtSecurityToken;
            var role = tokenS.Claims.First(claim => claim.Type == "Role").Value;
            return role;
        }
    }
}
