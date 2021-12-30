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
                        select c;

            return query.FirstOrDefault();
        }

        public List<Account> FindAll()
        {
            return ctx.Accounts.ToList<Account>();
        }

        public Account FindById(int id)
        {
            try
            {
                return ctx.Accounts.Single(s => s.Id == id);
            }
            catch
            {
                return null;
            }
        }

        public int Add(Account account)
        {
            try
            {
                ctx.Accounts.Add(account);
                var res = ctx.SaveChanges();
                if(res > 0)
                {

                    // nếu có set managerId thì sẽ set accountId bên Manager
                    if (account.ManagerId != null)
                    {
                        var manager = ctx.Managers.Single(s => s.Id == account.ManagerId);
                        var id = ctx.Accounts.Single(s => s.Username == account.Username).Id;
                        manager.AccountId = id;
                        ctx.SaveChanges();
                    }
                }
                return res;
            } catch
            {
                return -1;
            }
        }

        public int Update(int id, Account account)
        {
            try
            {
                Account acc = ctx.Accounts.Single(s => s.Id == id);

                acc.Username = account.Username;
                acc.Password = BCrypt.Net.BCrypt.HashPassword(account.Password);
                acc.RoleId = account.RoleId;
                acc.Name = account.Name;
                acc.Avatar = account.Avatar;
                acc.ManagerId = account.ManagerId;

                // nếu có set managerId thì sẽ set accountId bên Manager
                if (account.ManagerId != null)
                {
                    var manager = ctx.Managers.Single(s => s.Id == account.ManagerId);
                    manager.AccountId = id;
                }

                return ctx.SaveChanges();
                
            } catch
            {
                return -1;
            }
        }

        public int DeleteById(int id)
        {
            try
            {
                var acc = ctx.Accounts.Single(s => s.Id == id);
                ctx.Accounts.Remove(acc);
                return ctx.SaveChanges();
            } catch
            {
                return -1;
            }
        }
    }
}
