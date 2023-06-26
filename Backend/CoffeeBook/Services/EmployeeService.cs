using CoffeeBook.Contracts;
using CoffeeBook.DataAccess;
using CoffeeBook.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeBook.Services
{
    public class EmployeeService : IEmployeeService
    {
        public readonly CoffeeBookDbContext _context;

        public EmployeeService(CoffeeBookDbContext context)
        {
            _context = context;
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.Include(i => i.Store).ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            try
            {
                return _context.Employees.Single(s => s.Id == id);
            }
            catch
            {
                return null;
            }
        }

        public int AddNewEmployee(Employee model)
        {
            try
            {
                _context.Employees.Add(model);
                var result = _context.SaveChanges();
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public int UpdateEmployee(int id, Employee model)
        {
            try
            {
                var emp = _context.Employees.Single(s => s.Id == id);
                emp.Name = model.Name;
                emp.Age = model.Age;
                emp.Gender = model.Gender;
                emp.Address = model.Address;
                emp.Email = model.Email;
                emp.Phone = model.Phone;
                emp.Salary = model.Salary;
                emp.StoreId = model.StoreId;

                var result = _context.SaveChanges();
                return result;
            }
            catch
            {
                return -1;
            }
        }

        public int DeleteEmployee(int id)
        {
            try
            {
                var emp = _context.Employees.Single(s => s.Id == id);
                _context.Employees.Remove(emp);
                var result = _context.SaveChanges();
                return result;
            }
            catch
            {
                return -1;
            }
        }
    }
}