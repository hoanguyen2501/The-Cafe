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
    public class ManagerController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly ManagerService service;
        private readonly Context context;
        public ManagerController(IConfiguration config, Context ctx)
        {
            _config = config;
            context = ctx;
            service = new ManagerService(config, context);
        }

        [Route("managers")]
        [HttpGet]
        public JsonResult Get()
        {
            var stores = service.GetAllManagers();
            return new JsonResult(stores);
        }

        [Route("manager/{id}")]
        [HttpGet]
        public JsonResult GetById(int id)
        {
            var store = service.GetManagerById(id);
            return new JsonResult(store);
        }

        [Route("manager/create")]
        [HttpPost]
        public JsonResult Post(Manager manager)
        {
            if (ModelState.IsValid)
            {
                if (service.Post(manager) > 0)
                {
                    return new JsonResult("Added one manager successfully.");
                }

            }
            return new JsonResult("Cannot add new manager.");
        }

        [Route("manager/update/{id}")]
        [HttpPut]
        public JsonResult Put(int id, Manager manager)
        {
            if (ModelState.IsValid)
            {
                if (service.Put(id, manager) > 0)
                    return new JsonResult("Updated manager successfully.");
            }
            return new JsonResult("Cannot manager store.");
        }

        [Route("manager/delete/{id}")]
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            if (service.Delete(id) > 0)
                return new JsonResult("Deleted manager successfully.");

            return new JsonResult("Cannot delete manager.");
        }
    }
}
