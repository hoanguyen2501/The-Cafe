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
    public class SupplierService
    {
        private readonly IConfiguration _config;
        private readonly string sqlDataSource;
        private readonly Context ctx;

        public SupplierService()
        {
        }

        public SupplierService(IConfiguration config, Context context)
        {
            _config = config;
            sqlDataSource = _config.GetConnectionString("CoffeeBook");
            ctx = context;
        }

        public DataTable findAll()
        {
            DataTable table = new DataTable();
            string query = "select * from Supplier";
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

        public DataTable save(Supplier supplier)
        {
            DataTable table = new DataTable();
            string query = @$"insert into Supplier(name, description, address, city, country, phone, url)
                             values('{supplier.Name}',
                             '{supplier.Description}',
                             '{supplier.Address}',
                             '{supplier.City}',
                             '{supplier.Country}',
                             '{supplier.Phone}',
                             '{supplier.Url}')";

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

        public Supplier GetById(int id)
        {
            try
            {
                return ctx.Suppliers.Single(s => s.Id == id);
            }
            catch
            {
                return null;
            }
        }

        public DataTable deleteById(int id)
        {
            DataTable table = new DataTable();
            string query = @$"delete from Supplier
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

        public int Update(int id, Supplier supplier)
        {
            try
            {
                Supplier sup = ctx.Suppliers.Single(s => s.Id == id);
                sup.Name = supplier.Name;
                sup.Phone = supplier.Phone;
                sup.Url = supplier.Url;
                sup.Country = supplier.Country;
                sup.City = supplier.City;
                sup.Description = supplier.Description;
                sup.Address = supplier.Address;
                return ctx.SaveChanges();
            }
            catch { return -1; }
        }
    }
}
