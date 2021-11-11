using CoffeeBook.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBook.Controllers
{
    /*[Route("api/[controller]")]*/
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly string sqlDataSource;
        public BillController(IConfiguration config)
        {
            _config = config;
            sqlDataSource = _config.GetConnectionString("CoffeeBook");
        }

        [HttpGet("bill")]
        public JsonResult Get()
        {
            DataTable table = new DataTable();
            string query = "select * from Bill";
            MySqlDataReader myReader;
            using (MySqlConnection myCon = new MySqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }
            if (table == null)
                return new JsonResult("There is no data");
            return new JsonResult(table);
        }

        [HttpPost("bill/add")]
        public JsonResult Post(Bill bill)
        {
            DataTable table = new DataTable();
            string query = $"insert into Bill(UserId, Validated, Status, TotalPrice) " +
                           $"values('{bill.UserId}'," +
                           $"{bill.Validated}," +
                           $"'{bill.Status}'," +
                           $"'{bill.TotalPrice}')";

            MySqlDataReader myReader;
            using (MySqlConnection myCon = new MySqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("Added successfully.");
        }

        [HttpPut("bill/edit")]
        public JsonResult Put(Bill bill)
        {
            DataTable table = new DataTable();
            string query = @$"update Bill set
                              Validated = '{bill.Validated}',
                              Status = '{bill.Status}',
                              TotalPrice = '{bill.TotalPrice}'
                              where id = {bill.Id}";

            MySqlDataReader myReader;
            using (MySqlConnection myCon = new MySqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("Updated successfully.");
        }

        [HttpDelete("bill/delete/{id}")]
        public JsonResult Delete(int id)
        {
            DataTable table = new DataTable();
            string query = @$"delete from Bill 
                              where id = {id}";

            MySqlDataReader myReader;
            using (MySqlConnection myCon = new MySqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult($"Bill {id} is Deleted successfully.");
        }
    }
}
