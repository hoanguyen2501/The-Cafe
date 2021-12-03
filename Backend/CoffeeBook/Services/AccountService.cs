using CoffeeBook.DataAccess;
using CoffeeBook.Dto;
using CoffeeBook.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBook.Services
{
    public class AccountService
    {
        private readonly IConfiguration _config;
        private readonly string sqlDataSource;
        private readonly Context ctx;

        public AccountService()
        {
        }
        public AccountService(IConfiguration config)
        {
            _config = config;
            sqlDataSource = _config.GetConnectionString("CoffeeBook");
        }

        public AccountService(IConfiguration config, Context context)
        {
            _config = config;
            sqlDataSource = _config.GetConnectionString("CoffeeBook");
            ctx = context;
        }

        public Account Login(AdminLoginDto dto)
        {
            var query = from c in ctx.Accounts
                        where c.Username == dto.Username
                        where c.Password == dto.Password
                        select c;

            return query.FirstOrDefault();
        }

        public List<Account> FindAll()
        {
            return ctx.Accounts.ToList<Account>();
        }

        public int Add(Account account)
        {
            ctx.Accounts.Add(account);
            return ctx.SaveChanges();
        }
    }
}
