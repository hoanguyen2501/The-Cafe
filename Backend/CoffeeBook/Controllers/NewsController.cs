using CoffeeBook.Contracts;
using CoffeeBook.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoffeeBook.Controllers
{
    public class NewsController : BaseApiController
    {
        private readonly INewsService service;

        public NewsController(INewsService service)
        {
            this.service = service;
        }

        [HttpGet]
        public ActionResult Get()
        {
            List<News> news = service.GetAllNews();
            return new JsonResult(news);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            News news = service.GetNewsById(id);
            if (news == null)
                return BadRequest();

            return new JsonResult(news);
        }

        [Authorize(Roles = "1")]
        [HttpPost("add")]
        public ActionResult Post(News news)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var Role = GetCurrentRole(jwt);
                if (Role == "1" || Role == "2")
                {
                    int res = service.AddNewNews(news);
                    if (res > 0) return Ok();

                    return BadRequest();
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }

        [HttpPut("edit/{id}")]
        public ActionResult Put(int id, News news)
        {
            string jwt = Request.Cookies["jwt"];
            if (!string.IsNullOrEmpty(jwt))
            {
                var role = GetCurrentRole(jwt);
                if (role == "1" || role == "2")
                {
                    int res = service.UpdateNews(id, news);
                    if (res > 0) return Ok();
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
                    int res = service.DeleteNews(id);
                    if (res > 0) return Ok();
                    return BadRequest();
                }
            }
            return Unauthorized(new { message = "Bạn không có quyền truy cập" });
        }
    }
}