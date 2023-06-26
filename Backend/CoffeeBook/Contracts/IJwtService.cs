using CoffeeBook.Models;

namespace CoffeeBook.Contracts
{
    public interface IJwtService
    {
        string GenerateAccountToken(Account account);

        string GenerateCustomerToken(Customer customer);

        int? ValidateToken(string jwt);
    }
}