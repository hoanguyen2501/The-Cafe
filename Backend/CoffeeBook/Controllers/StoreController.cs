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
        public JsonResult Get()
        {
            var stores = service.GetAllStores();
            return new JsonResult(stores);
        }

        [Route("store/{id}")]
        [HttpGet]
        public JsonResult GetById(int id)
        {
            var store = service.GetStoreById(id);
            return new JsonResult(store);
        }

        [Route("store/create")]
        [HttpPost]
        public JsonResult Post(Store store)
        {
            if (ModelState.IsValid)
            {
                if (service.Post(store) > 0)
                {
                    return new JsonResult("Added one store successfully.");
                }

            }
            return new JsonResult("Cannot add new store.");
        }

        [Route("store/update/{id}")]
        [HttpPut]
        public JsonResult Put(int id, Store store)
        {
            if (ModelState.IsValid)
            {
                if (service.Put(id, store) > 0)
                    return new JsonResult("Updated store successfully.");
            }
            return new JsonResult("Cannot update store.");
        }

        [Route("store/delete/{id}")]
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            if (service.Delete(id) > 0)
                return new JsonResult("Deleted store successfully.");

            return new JsonResult("Cannot delete store.");
        }
    }
}
