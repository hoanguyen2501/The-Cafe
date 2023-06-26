using CoffeeBook.Contracts;
using CoffeeBook.Dto;
using CoffeeBook.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace CoffeeBook.Controllers
{
    public class CustomerController : BaseApiController
    {
        private readonly ICustomerService _service;
        private readonly IJwtService _jwtService;

        public CustomerController(
            ICustomerService service,
            IJwtService jwtService)
        {
            _service = service;
            _jwtService = jwtService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var Role = GetCurrentRole(jwt);
                if (Role == "1")
                {
                    List<Customer> customers = _service.GetAllCustomers();
                    return new JsonResult(customers);
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            string jwt = Request.Cookies["jwt"];
            string jwtCustomer = Request.Cookies["jwtCustomer"];
            if (!string.IsNullOrEmpty(jwt) || !string.IsNullOrEmpty(jwtCustomer))
            {
                string Role = "", cusRole = "", cusId = "";
                if (!string.IsNullOrEmpty(jwt))
                {
                    Role = GetCurrentRole(jwt);
                }
                if (!string.IsNullOrEmpty(jwtCustomer))
                {
                    cusRole = GetCustomerRole(jwtCustomer);
                    cusId = GetCustomerId(jwtCustomer);
                }
                if (Role == "1" || (cusRole == "Customer" && cusId == id.ToString()))
                {
                    Customer list = _service.GetCustomerById(id);
                    if (list == null) return BadRequest();
                    return new JsonResult(list);
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }

        [HttpPost("add")]
        public ActionResult Create(Customer customer)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var Role = GetCurrentRole(jwt);
                if (Role == "1")
                {
                    int res = _service.AddNewCustomer(customer);
                    if (res > 0) return Ok();

                    return BadRequest();
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }

        [HttpPut("edit/{id}")]
        public ActionResult Put(int id, Customer customer)
        {
            string jwt = Request.Cookies["jwt"];
            string jwtCustomer = Request.Cookies["jwtCustomer"];
            if (!string.IsNullOrEmpty(jwt) || !string.IsNullOrEmpty(jwtCustomer))
            {
                string Role = "", cusRole = "";
                if (!string.IsNullOrEmpty(jwt))
                {
                    Role = GetCurrentRole(jwt);
                }
                if (!string.IsNullOrEmpty(jwtCustomer))
                {
                    cusRole = GetCustomerRole(jwtCustomer);
                }

                if (Role == "1" || cusRole == "Customer")
                {
                    int res = _service.UpdateCustomer(id, customer);
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
                    int res = _service.DeleteCustomerById(id);
                    if (res > 0) return Ok();
                    return BadRequest();
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }

        [HttpPost("login")]
        public ActionResult Login(SigninDto dto)
        {
            Customer user = _service.CustomerLogin(dto);

            if (user == null)
                return BadRequest(new { message = "Username or Password is invalid" });

            if (!BCrypt.Net.BCrypt.Verify(dto.Password, user.Password))
            {
                return Unauthorized(new { message = "Invalid Credentials" });
            }

            var token = _jwtService.GenerateCustomerToken(user);

            Response.Cookies.Append("jwtCustomer", token, new CookieOptions
            {
                HttpOnly = true
            });

            return new JsonResult(new { Token = token });
        }

        [HttpPost("register")]
        public ActionResult Register(SignupDto dto)
        {
            string res = _service.CustomerRegister(dto);
            if (res == "1") return Ok();
            else return new JsonResult(res);
        }

        [HttpPost("logout")]
        public ActionResult Logout()
        {
            Response.Cookies.Delete("jwtCustomer");
            return Ok(new { message = "Đã đăng xuất" });
        }

        [HttpPut("forgot/{email}")]
        public ActionResult ForgotPassword(string email, ForgotPassDto dto)
        {
            var res = _service.CustomerChangePassword(email, dto);
            if (res > 0)
                return Ok();
            return BadRequest();
        }

        private static string GetCustomerRole(string jwtCustomer)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(jwtCustomer);
            var tokenS = jsonToken as JwtSecurityToken;
            var role = tokenS.Claims.First(claim => claim.Type == "Role").Value;
            return role;
        }

        private static string GetCustomerId(string jwt)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(jwt);
            var tokenS = jsonToken as JwtSecurityToken;
            var id = tokenS.Claims.First(claim => claim.Type == "Id").Value;
            return id;
        }
    }
}