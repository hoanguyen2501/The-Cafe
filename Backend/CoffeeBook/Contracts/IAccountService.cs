using CoffeeBook.Models;
using CoffeeBook.Models.Authen;
using System.Collections.Generic;

namespace CoffeeBook.Contracts
{
    public interface IAccountService
    {
        Account Login(AuthenticationRequest dto);

        List<Account> GetAllAccounts();

        Account GetAccountById(int id);

        int CreateAccount(Account account);

        int UpdateAccount(int id, Account account);

        int DeleteAccount(int id);
    }
}