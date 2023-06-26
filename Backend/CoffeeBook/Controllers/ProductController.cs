using CoffeeBook.Contracts;
using CoffeeBook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoffeeBook.Controllers
{
    public class ProductController : BaseApiController
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet("all")]
        public JsonResult Get()
        {
            List<Product> products = _service.GetAll();
            return new JsonResult(products);
        }

        [HttpGet("{id}")]
        public ActionResult GetProductById(int id)
        {
            Product product = _service.GetById(id);
            if (product == null) return BadRequest();
            return new JsonResult(product);
        }

        [HttpPost("create")]
        public ActionResult Post(Product product)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var role = GetCurrentRole(jwt);
                if (role == "1" || role == "2")
                {
                    if (ModelState.IsValid)
                    {
                        if (_service.AddNewProduct(product) > 0)
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
        public ActionResult Put(int id, Product product)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var Role = GetCurrentRole(jwt);
                if (Role == "1" || Role == "2")
                {
                    if (ModelState.IsValid)
                    {
                        if (_service.UpdateProduct(id, product) > 0)
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
                    if (_service.DeleteProduct(id) > 0)
                        return Ok();

                    return BadRequest();
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }
    }
}