using CoffeeBook.Contracts;
using CoffeeBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeBook.Controllers
{
    public class DiscountController : BaseApiController
    {
        private readonly IDiscountService _service;

        public DiscountController(IDiscountService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var discounts = _service.GetAllDiscounts();
            return new JsonResult(discounts);
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var discount = _service.GetDiscountById(id);
            if (discount == null)
                return BadRequest();

            return new JsonResult(discount);
        }

        [HttpPost("add")]
        public ActionResult Create(Discount discount)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var Role = GetCurrentRole(jwt);
                if (Role == "1" || Role == "2")
                {
                    var result = _service.AddNewDiscount(discount);
                    if (result > 0)
                        return Ok();

                    return BadRequest();
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }

        [HttpPut("edit/{id}")]
        public ActionResult Update(int id, Discount discount)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var Role = GetCurrentRole(jwt);
                if (Role == "1" || Role == "2")
                {
                    var result = _service.UpdateDiscount(id, discount);

                    if (result > 0)
                        return Ok();

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
                    var result = _service.DeleteDiscount(id);

                    if (result > 0)
                        return Ok();

                    return BadRequest();
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }
    }
}