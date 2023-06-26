using CoffeeBook.Models;
using System.Collections.Generic;

namespace CoffeeBook.Contracts
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();

        Employee GetEmployeeById(int id);

        int AddNewEmployee(Employee model);

        int UpdateEmployee(int id, Employee model);

        int DeleteEmployee(int id);
    }
}