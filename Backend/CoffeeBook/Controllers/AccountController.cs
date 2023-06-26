using CoffeeBook.Authorization;
using CoffeeBook.Contracts;
using CoffeeBook.Models;
using CoffeeBook.Models.Authen;
using CoffeeBook.Models.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoffeeBook.Controllers
{
    [Authorize]
    public class AccountController : BaseApiController
    {
        private readonly IAccountService _service;
        private readonly IJwtService _jwtService;

        public AccountController(
            IAccountService service,
            IJwtService jwtService)
        {
            _service = service;
            _jwtService = jwtService;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public ActionResult<AuthenticationResponse> Login(AuthenticationRequest dto)
        {
            Account account = _service.Login(dto);

            if (account == null || !BCrypt.Net.BCrypt.Verify(dto.Password, account.Password))
            {
                return BadRequest(new { message = "Username or Password is invalid." });
            }

            var token = _jwtService.GenerateAccountToken(account);

            Response.Cookies.Append("jwt", token, new CookieOptions
            {
                HttpOnly = true
            });

            var response = new AuthenticationResponse(account, token);

            return Ok(response);
        }

        [HttpPost]
        public ActionResult Logout()
        {
            Response.Cookies.Delete("jwt");
            return Ok(new { message = "Đã đăng xuất" });
        }

        [Authorize(RoleEnum.Admin)]
        [HttpGet("all")]
        public ActionResult GetAllAccount()
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var role = GetCurrentRole(jwt);
                if (role == "1")
                {
                    List<Account> accounts = _service.GetAllAccounts();
                    if (accounts.Count == 0)
                        return Ok("There is no data");

                    return Ok(accounts);
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }

        [HttpGet("{id}")]
        public ActionResult GetAccountById(int id)
        {
            var account = _service.GetAccountById(id);
            var currentAccount = (Account)HttpContext.Items["User"];
            bool isAccessed;
            if (currentAccount.RoleId == (int)RoleEnum.Admin)
                isAccessed = true;
            else if (currentAccount.Id != account.Id)
                isAccessed = false;
            else
                isAccessed = true;

            if (!isAccessed)
                return Unauthorized(new { message = "Bạn không có quyền truy cập" });

            return Ok(account);
        }

        [Authorize(RoleEnum.Admin)]
        [HttpPost("add")]
        public ActionResult AddAccount(Account account)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var role = GetCurrentRole(jwt);
                if (role == "1")
                {
                    var newAcc = new Account
                    {
                        Username = account.Username,
                        Password = BCrypt.Net.BCrypt.HashPassword(account.Password),
                        RoleId = account.RoleId,
                    };
                    int result = _service.CreateAccount(newAcc);
                    if (result > 0)
                        return Ok();
                    return BadRequest();
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }

        [Authorize(RoleEnum.Admin)]
        [HttpPut("edit/{id}")]
        public ActionResult UpdateAccount(int id, Account account)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var role = GetCurrentRole(jwt);
                if (role == "1")
                {
                    if (ModelState.IsValid)
                    {
                        int res = _service.UpdateAccount(id, account);
                        if (res > 0) return Ok();
                        else return BadRequest();
                    }
                    return BadRequest();
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }

        [Authorize(RoleEnum.Admin)]
        [HttpDelete("delete/{id}")]
        public ActionResult DeleteAccount(int id)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var role = GetCurrentRole(jwt);
                if (role == "1")
                {
                    int res = _service.DeleteAccount(id);
                    if (res > 0) return Ok();
                    else return BadRequest();
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }
    }
}