using CoffeeBook.Models;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBook.Services
{
    public class DiscountService
    {
        private readonly IConfiguration _config;
        private readonly string sqlDataSource;

        public DiscountService()
        {
        }

        public DiscountService(IConfiguration config)
        {
            _config = config;
            sqlDataSource = _config.GetConnectionString("CoffeeBook");
        }

        public DataTable findAll()
        {
            DataTable table = new DataTable();
            string query = "select * from Discount";
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
            return table;
        }

        public DataTable save(Discount discount)
        {
            DataTable table = new DataTable();
            string query = @$"insert into Discount(name, value, quantity, expiredDate, photo)
                             values('{discount.Name}',
                             {discount.Value},
                             {discount.Quantity},
                             {discount.ExpiredDate},
                             '{discount.Photo}')";

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
            return table;
        }

        public DataTable deleteById(int id)
        {
            DataTable table = new DataTable();
            string query = @$"delete from Discount
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
            return table;
        }

        public DataTable update(Discount discount)
        {
            DataTable table = new DataTable();
            string query = @$"update Discount set
                              name = '{discount.Name}',
                              value = {discount.Value},
                              quantity = {discount.Quantity}
                              where id = {discount.Id}";

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
            return table;
        }
    }
}
