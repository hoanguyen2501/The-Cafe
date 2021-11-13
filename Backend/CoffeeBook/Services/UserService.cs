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
    public class UserService
    {
        private readonly IConfiguration _config;
        private readonly string sqlDataSource;

        public UserService()
        {
        }

        public UserService(IConfiguration config)
        {
            _config = config;
            sqlDataSource = _config.GetConnectionString("CoffeeBook");
        }

        public DataTable findAll()
        {
            DataTable table = new DataTable();
            string query = "select * from User";
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

        public DataTable save(User user)
        {
            DataTable table = new DataTable();
            string query = $"insert into User(username, password, email, phone, name, avata, address, gender) " +
                           $"values('{user.Username}'," +
                           $"'{user.Password}'," +
                           $"'{user.Email}'," +
                           $"'{user.Phone}'," +
                           $"'{user.Name}'," +
                           $"'{user.Avata}'," +
                           $"'{user.Address}'," +
                           $"{user.Gender})";

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
            User user = new User();
            user.Username = dto.Username;
            user.Password = dto.Password;
            user.Phone = dto.Phone;
            user.Email = dto.Email;
            /*user.Gender = dto.Gender;*/

            DataTable table = new DataTable();
            string query = $"insert into User(username, password, email, phone) " +
                           $"values('{user.Username}'," +
                           $"'{user.Password}'," +
                           $"'{user.Email}'," +
                           $"'{user.Phone}')";

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
            string query = @$"delete from User 
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

        public DataTable update(User user)
        {
            DataTable table = new DataTable();
            string query = @$"update User set
                              password = '{user.Password}',
                              phone = '{user.Phone}',
                              name = '{user.Name}',
                              avata = '{user.Avata}',
                              address = '{user.Address}',
                              gender = {user.Gender}
                              where id = {user.Id}";

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
