using CoffeeBook.Contracts;
using CoffeeBook.DataAccess;
using CoffeeBook.Models;
using CoffeeBook.Models.Authen;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeBook.Services
{
    public class AccountService : IAccountService
    {
        private readonly CoffeeBookDbContext _context;

        public AccountService(CoffeeBookDbContext context)
        {
            _context = context;
        }

        public Account Login(AuthenticationRequest dto)
        {
            dto.Username = dto.Username.Trim();
            var account = _context.Accounts
                .FirstOrDefault(x => x.Username == dto.Username);

            return account;
        }

        public List<Account> GetAllAccounts() => _context.Accounts.ToList();

        public Account GetAccountById(int id) => _context.Accounts.Find(id);

        public int CreateAccount(Account account)
        {
            try
            {
                _context.Accounts.Add(account);
                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }

        public int UpdateAccount(int id, Account account)
        {
            try
            {
                Account acc = _context.Accounts.Find(id);

                acc.Username = account.Username;
                acc.Password = BCrypt.Net.BCrypt.HashPassword(account.Password);
                acc.RoleId = account.RoleId;

                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }

        public int DeleteAccount(int id)
        {
            try
            {
                var acc = _context.Accounts.Find(id);
                _context.Accounts.Remove(acc);
                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }
    }
}