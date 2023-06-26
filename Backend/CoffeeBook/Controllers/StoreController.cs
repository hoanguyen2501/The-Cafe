using CoffeeBook.Contracts;
using CoffeeBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeBook.Controllers
{
    public class StoreController : BaseApiController
    {
        private readonly IStoreService _service;

        public StoreController(IStoreService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult GetAllStores()
        {
            var stores = _service.GetAllStores();
            return new JsonResult(stores);
        }

        [HttpGet("district")]
        public ActionResult GetStoreByDistrict()
        {
            var stores = _service.GetByDistrict();
            return new JsonResult(stores);
        }

        [HttpGet("{id}")]
        public ActionResult GetStoreById(int id)
        {
            var store = _service.GetStoreById(id);
            if (store == null) return BadRequest();
            return new JsonResult(store);
        }

        [HttpPost("create")]
        public ActionResult Create(Store store)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var Role = GetCurrentRole(jwt);
                if (Role == "1" || Role == "2")
                {
                    if (ModelState.IsValid)
                    {
                        if (_service.AddNewStore(store) > 0)
                        {
                            return Ok();
                        }
                    }
                    return BadRequest();
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }

        [HttpPut("update/{id}")]
        public ActionResult Update(int id, Store store)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var Role = GetCurrentRole(jwt);
                if (Role == "1" || Role == "2")
                {
                    if (ModelState.IsValid)
                    {
                        if (_service.UpdateStore(id, store) > 0)
                            return Ok();
                    }
                    return BadRequest();
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }

        [HttpDelete("delete/{id}")]
        public ActionResult Delete(int id)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var Role = GetCurrentRole(jwt);
                if (Role == "1" || Role == "2")
                {
                    if (_service.DeleteStore(id) > 0)
                        return Ok();

                    return BadRequest();
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }
    }
}