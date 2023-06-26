using CoffeeBook.Contracts;
using CoffeeBook.Extensions;
using CoffeeBook.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace CoffeeBook.Controllers
{
    public class EmployeeController : BaseApiController
    {
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet("all")]
        public JsonResult GetAll()
        {
            var employees = _service.GetAllEmployees();
            return new JsonResult(employees);
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var employee = _service.GetEmployeeById(id);
            if (employee == null) return BadRequest();
            return new JsonResult(employee);
        }

        [HttpPost("create")]
        public ActionResult Post(Employee employee)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var Role = GetCurrentRole(jwt);
                if (Role == "1" || Role == "2")
                {
                    if (ModelState.IsValid)
                    {
                        if (_service.AddNewEmployee(employee) > 0)
                        {
                            return Ok();
                        }
                    }
                    return BadRequest();
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }

        [HttpGet("export")]
        public ActionResult ExportExcel()
        {
            var employees = _service.GetAllEmployees();
            if (employees is null)
                return BadRequest();
            if (employees.Count == 0)
                return Content("Không có nhân viên nào.");

            var stream = new MemoryStream();
            GenerateExcelTableExtensions.ExportEmployeeList(stream, employees);
            stream.Position = 0;

            var fileName = $"Danh-sach-nhan-vien_{DateTime.Now}.xlsx";

            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }

        [HttpPut("update/{id}")]
        public ActionResult Put(int id, Employee employee)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var Role = GetCurrentRole(jwt);
                if (Role == "1" || Role == "2")
                {
                    if (ModelState.IsValid)
                    {
                        if (_service.UpdateEmployee(id, employee) > 0)
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
                    if (_service.DeleteEmployee(id) > 0)
                        return Ok();

                    return BadRequest();
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }
    }
}