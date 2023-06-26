using CoffeeBook.Contracts;
using CoffeeBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeBook.Controllers
{
    public class RoleController : BaseApiController
    {
        private readonly IRoleService _service;

        public RoleController(IRoleService service)
        {
            _service = service;
        }

        [HttpGet("all")]
        public ActionResult Get()
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var Role = GetCurrentRole(jwt);
                if (Role == "1")
                {
                    var roles = _service.GetAllRoles();
                    return new JsonResult(roles);
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var Role = GetCurrentRole(jwt);
                if (Role == "1")
                {
                    Role role = _service.GetRoleById(id);
                    if (role == null) return BadRequest();
                    else return new JsonResult(role);
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }

        [HttpPost("add")]
        public ActionResult AddRole(Role role)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var Role = GetCurrentRole(jwt);
                if (Role == "1")
                {
                    int result = _service.AddNewRole(role);
                    if (result > 0)
                        return Ok();
                    return BadRequest();
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }

        [HttpPut("edit/{id}")]
        public IActionResult UpdateRole(int id, Role role)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var Role = GetCurrentRole(jwt);
                if (Role == "1")
                {
                    if (ModelState.IsValid)
                    {
                        int res = _service.UpdateRole(id, role);
                        if (res > 0) return Ok();
                        else return BadRequest();
                    }
                    return BadRequest();
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteRole(int id)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var Role = GetCurrentRole(jwt);
                if (Role == "1")
                {
                    int res = _service.DeleteRole(id);
                    if (res > 0) return Ok();
                    return BadRequest();
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }
    }
}