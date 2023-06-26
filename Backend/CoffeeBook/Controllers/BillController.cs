using CoffeeBook.Contracts;
using CoffeeBook.Dto;
using CoffeeBook.Extensions;
using CoffeeBook.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;

namespace CoffeeBook.Controllers
{
    public class BillController : BaseApiController
    {
        private readonly IBillService _service;

        public BillController(IBillService service)
        {
            _service = service;
        }

        [HttpGet("all")]
        public ActionResult Get()
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var role = GetCurrentRole(jwt);
                if (role == "1" || role == "2" || role == "3" || role == "4")
                {
                    List<Bill> bills = _service.GetAll();
                    return new JsonResult(bills);
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }

        [HttpGet("{id}")]
        public JsonResult GetByCustomerId(int id)
        {
            List<Bill> bills = _service.GetBillsByCustomerId(id);
            return new JsonResult(bills);
        }

        [HttpGet("sales/year/{year}")]
        public JsonResult GetSaleByYearMonth(int year)
        {
            var sales = _service.GetSaleByYear(year);
            return new JsonResult(sales);
        }

        [HttpGet("totalsale/{year}")]
        public ActionResult GetTotalSaleByYear(int year)
        {
            var sale = _service.GetTotalSaleByYear(year);
            return new JsonResult(sale);
        }

        [HttpGet("count/{year}")]
        public ActionResult GetCountBill(int year)
        {
            var count = _service.GetCountBill(year);
            return new JsonResult(count);
        }

        // url: .../bill/sales/date/month-day-year
        // example: .../bill/sales/date/12-24-2021
        [HttpGet("sales/date/{date}")]
        public ActionResult GetSaleByDay(DateTime date)
        {
            var sale = _service.GetRevenueByDay(date);
            return new JsonResult(sale);
        }

        ////
        [HttpGet("sales/months/{param}")]
        public ActionResult GetSaleByMonth(string param)
        {
            string[] parameters = param.Split("-");
            int month = int.Parse(parameters[0]);
            int year = int.Parse(parameters[1]);
            var sale = _service.GetRevenueByMonth(month, year);
            return new JsonResult(sale);
        }

        /// <summary>
        ///
        /// <returns></returns>
        [Route("bill/sales/years/{year}")]
        [HttpGet]
        public ActionResult GetSaleByYear(int year)
        {
            var sale = _service.GetRevenueByYear(year);
            return new JsonResult(sale);
        }

        [Route("bill/total/{year}")]
        [HttpGet]
        public ActionResult GetTotalListBill(int year)
        {
            var count = _service.GetTotalListBill(year);
            return new JsonResult(count);
        }

        // url: .../bill/revenue/date/month-day-year
        // example: .../bill/revenue/date/12-24-2021
        [HttpGet("revenue/date/{date}")]
        public ActionResult GetRevenueByDay(DateTime date)
        {
            var revenue = _service.GetRevenueByDay(date);
            if (revenue.Rows.Count < 1)
                return BadRequest();

            MemoryStream stream = new();

            GenerateExcelTableExtensions.ExportRevenueByDay(stream, revenue, date);

            var fileName = $"Doanh-thu-ngay-{date.Day}/{date.Month}/{date.Year}_{DateTime.Now:dd/MM/yyyy}.xlsx";

            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }

        // url: ...
        [HttpGet("revenue/month/{param}")]
        public ActionResult GetRevenueByMonth(string param)
        {
            string[] parameters = param.Split("-");
            int month = int.Parse(parameters[0]);
            int year = int.Parse(parameters[1]);
            var revenue = _service.GetRevenueByMonth(month, year);
            if (revenue.Rows.Count < 1)
                return BadRequest();

            MemoryStream stream = new();

            GenerateExcelTableExtensions.ExportRevenueByMonth(stream, revenue, month, year);

            stream.Position = 0;

            var fileName = $"Doanh-thu-thang-{month}-{year}_{DateTime.Now}.xlsx";

            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }

        // url: .../bill/revenue/year/2021
        [HttpGet("revenue/year/{year}")]
        public ActionResult GetRevenueByYear(int year)
        {
            var revenue = _service.GetRevenueByYear(year);
            if (revenue.Rows.Count < 1)
                return BadRequest();

            MemoryStream stream = new();
            GenerateExcelTableExtensions.ExportRevenueByYear(stream, revenue, year);

            stream.Position = 0;
            var fileName = $"Doanh-thu-nam-{year}_{DateTime.Now}.xlsx";

            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }

        [HttpPost("add")]
        public ActionResult Create(Bill bill)
        {
            int table = _service.AddNewBill(bill);
            if (table > 0) return Ok();
            else return BadRequest();
        }

        [HttpPut("edit/{id}")]
        public ActionResult Update(int id, Bill bill)
        {
            int res = _service.UpdateBill(id, bill);
            if (res > 0) return Ok();
            else return BadRequest();
        }

        [HttpDelete("delete/{id}")]
        public ActionResult Delete(int id)
        {
            int res = _service.DeleteById(id);
            if (res > 0) return Ok();
            else return BadRequest();
        }

        [HttpPost("purchase")]
        public ActionResult Purchase(BillDto dto)
        {
            int result = _service.Purchase(dto);
            if (result > 0)
                return Ok();
            else return Ok();
        }

        [HttpPut("delivery/{id}")]
        public ActionResult Delivery(int id)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var role = GetCurrentRole(jwt);
                if (role == "4" || role == "1")
                {
                    int res = _service.Delivery(id);
                    if (res > 0) return Ok();
                    else return BadRequest();
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }
    }
}