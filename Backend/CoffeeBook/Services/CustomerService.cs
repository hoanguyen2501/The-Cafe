using CoffeeBook.DataAccess;
using CoffeeBook.Dto;
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
    public class CustomerService
    {
        private readonly IConfiguration _config;
        private readonly string sqlDataSource;
        private readonly Context ctx;

        public CustomerService()
        {
        }

        public CustomerService(IConfiguration config)
        {
            _config = config;
            sqlDataSource = _config.GetConnectionString("CoffeeBook");
        }

        public CustomerService(IConfiguration config, Context context)
        {
            _config = config;
            sqlDataSource = _config.GetConnectionString("CoffeeBook");
            ctx = context;
        }

        public DataTable findAll()
        {
            DataTable table = new DataTable();
            string query = "select * from Customer";
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

        public DataTable save(Customer customer)
        {
            DataTable table = new DataTable();
            string query = $"insert into Customer(username, password, email, phone, name, avata, address, gender) " +
                           $"values('{customer.Username}'," +
                           $"'{customer.Password}'," +
                           $"'{customer.Email}'," +
                           $"'{customer.Phone}'," +
                           $"'{customer.Name}'," +
                           $"'{customer.Avata}'," +
                           $"'{customer.Address}'," +
                           $"{customer.Gender})";

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

        public DataTable Register(SignupDto dto)
        {
            Customer customer = new Customer();
            customer.Username = dto.Username;
            customer.Password = dto.Password;
            customer.Phone = dto.Phone;
            customer.Email = dto.Email;
            /*customer.Gender = dto.Gender;*/

            DataTable table = new DataTable();
            string query = $"insert into Customer(username, password, email, phone) " +
                           $"values('{customer.Username}'," +
                           $"'{customer.Password}'," +
                           $"'{customer.Email}'," +
                           $"'{customer.Phone}')";

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

        public List<Object> Login(SigninDto dto)
        {
            var query = from c in ctx.Customers
                        where c.Username == dto.Username
                        where c.Password == dto.Password
                        select c;

            return query.ToList<Object>();
        }

        public DataTable deleteById(int id)
        {
            DataTable table = new DataTable();
            string query = @$"delete from Customer 
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

        public DataTable update(Customer customer)
        {
            DataTable table = new DataTable();
            string query = @$"update Customer set
                              password = '{customer.Password}',
                              phone = '{customer.Phone}',
                              name = '{customer.Name}',
                              avata = '{customer.Avata}',
                              address = '{customer.Address}',
                              gender = {customer.Gender}
                              where id = {customer.Id}";

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
