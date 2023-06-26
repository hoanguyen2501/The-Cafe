using CoffeeBook.Contracts;
using CoffeeBook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoffeeBook.Controllers
{
    public class SupplierController : BaseApiController
    {
        private readonly ISupplierService _service;

        public SupplierController(ISupplierService service)
        {
            _service = service;
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            List<Supplier> suppliers = _service.GetAllSuppliers();
            return new JsonResult(suppliers);
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            Supplier sup = _service.GetSupplierById(id);
            if (sup == null) return BadRequest();
            else return new JsonResult(sup);
        }

        [HttpPost("add")]
        public ActionResult Create(Supplier supplier)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var Role = GetCurrentRole(jwt);
                if (Role == "1")
                {
                    int res = _service.AddNewSupplier(supplier);
                    if (res > 0) return Ok();
                    return BadRequest();
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }

        [HttpPut("edit/{id}")]
        public ActionResult Update(int id, Supplier supplier)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var Role = GetCurrentRole(jwt);
                if (Role == "1")
                {
                    int res = _service.UpdateSupplier(id, supplier);
                    if (res > 0) return Ok();
                    else return BadRequest();
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
                if (Role == "1")
                {
                    int res = _service.DeleteSupplier(id);
                    if (res > 0) return Ok();
                    return BadRequest();
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }
    }
}