using CoffeeBook.Dto;
using CoffeeBook.Models;
using System.Collections.Generic;

namespace CoffeeBook.Contracts
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomers();

        Customer GetCustomerById(int id);

        int AddNewCustomer(Customer customer);

        int UpdateCustomer(int id, Customer customer);

        int DeleteCustomerById(int id);

        string CustomerRegister(SignupDto dto);

        Customer CustomerLogin(SigninDto dto);

        int CustomerChangePassword(string email, ForgotPassDto dto);
    }
}