using CoffeeBook.DataAccess;
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
    public class ProductService
    {
        private readonly IConfiguration _config;
        private readonly string sqlDataSource;
        private readonly Context ctx;

        public ProductService()
        {
        }

        public ProductService(IConfiguration config)
        {
            _config = config;
            sqlDataSource = _config.GetConnectionString("CoffeeBook");
        }

        public ProductService(IConfiguration config, Context context)
        {
            _config = config;
            sqlDataSource = _config.GetConnectionString("CoffeeBook");
            ctx = context;
        }

        public List<Product> FindAll()
        {
            var query = from p in ctx.Products
                        select p;
            return query.ToList<Product>();
        }

        public DataTable deleteById(int id)
        {
            DataTable table = new DataTable();
            string query = @$"delete from Product 
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
    }
}
