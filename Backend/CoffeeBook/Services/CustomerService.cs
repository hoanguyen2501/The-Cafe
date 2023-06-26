using CoffeeBook.Contracts;
using CoffeeBook.DataAccess;
using CoffeeBook.Dto;
using CoffeeBook.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace CoffeeBook.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly CoffeeBookDbContext _context;

        public CustomerService(CoffeeBookDbContext context)
        {
            _context = context;
        }

        public List<Customer> GetAllCustomers() => _context.Customers.ToList();

        public Customer GetCustomerById(int id) => _context.Customers.Find(id);

        public int AddNewCustomer(Customer customer)
        {
            try
            {
                _context.Customers.Add(customer);
                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }

        public int UpdateCustomer(int id, Customer customer)
        {
            try
            {
                Customer cus = _context.Customers.Find(id);
                _context.Entry(cus).State = EntityState.Modified;
                cus.Name = customer.Name;
                cus.Email = customer.Email;
                cus.Phone = customer.Phone;
                cus.Address = customer.Address;
                cus.Gender = customer.Gender;
                cus.Avata = customer.Avata;
                _context.Entry(cus).Property(p => p.Role).IsModified = false;

                return _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public int DeleteCustomerById(int id)
        {
            try
            {
                var customer = _context.Customers.Find(id);
                _context.Customers.Remove(customer);
                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }

        public string CustomerRegister(SignupDto dto)
        {
            var errorList = new List<string>();
            bool[] flag = { false, false, false };
            var customers = _context.Customers.ToList();
            foreach (var cust in customers)
            {
                if (cust.Username == dto.Username)
                {
                    if (!flag[0])
                    {
                        flag[0] = true;
                        errorList.Add("Username");
                    }
                }
                if (cust.Email == dto.Email)
                {
                    if (!flag[1])
                    {
                        flag[1] = true;
                        errorList.Add("Email");
                    }
                }
                if (cust.Phone == dto.Phone)
                {
                    if (!flag[2])
                    {
                        flag[2] = true;
                        errorList.Add("Phone");
                    }
                }
            }
            if (errorList.Count != 0) return JsonSerializer.Serialize(errorList);
            try
            {
                Customer customer = new()
                {
                    Username = dto.Username,
                    Password = BCrypt.Net.BCrypt.HashPassword(dto.Password),
                    Phone = dto.Phone,
                    Email = dto.Email,
                    Name = dto.Name
                };

                _context.Customers.Add(customer);
                var res = _context.SaveChanges();
                if (res > 0) return "1";
                return "";
            }
            catch
            {
                return "0";
            }
        }

        public Customer CustomerLogin(SigninDto dto) =>
            _context.Customers.FirstOrDefault(x => x.Username == dto.Username);

        public int CustomerChangePassword(string email, ForgotPassDto dto)
        {
            try
            {
                Customer customer = _context.Customers.FirstOrDefault(s => s.Email == email);
                if (customer == null)
                    return 0;
                customer.Password = BCrypt.Net.BCrypt.HashPassword(dto.NewPassword);

                _context.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
    }
}