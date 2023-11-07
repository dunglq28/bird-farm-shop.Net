using BFShopBussinessObjects.Entities;
using BFShopBussinessObjects.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopDAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        private static object objectLock = new object();

        public static AccountDAO Instance
        {
            get
            {
                lock (objectLock)
                {
                    if (instance == null)
                    {
                        instance = new AccountDAO();
                    }
                    return instance;
                }
            }
        }

        public bool Create(Account account)
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                context.Accounts.Add(account);
                return context.SaveChanges() > 0;
            }
        }

        public List<Account> GetAccounts()
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                return context.Accounts.ToList();
            };

        }

        public Account CheckLogin(string email, string password)
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                var accountEntity = context.Accounts.Where(x => x.Email.Equals(email)
                                                     && x.Password.Equals(password))
                                           .Include(x => x.Role)
                                           .FirstOrDefault();
                if (accountEntity is not null) return accountEntity;
            }
            return null!;
        }

        public Account GetAccount(string? email)
        {
            if (email is not null)
                return GetAccounts().Where(x => x.Email.Equals(email))
                                      .FirstOrDefault();
            return null!;
        }

        public bool Update(string email, Account account)
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                var accountEntity
                    = context.Accounts.Where(x => x.Email.Equals(email)).FirstOrDefault();

                if (account is not null)
                {
                    accountEntity.Fullname = account.Fullname;
                    accountEntity.Password = account.Password;
                    accountEntity.RoleId = account.RoleId;

                    context.SaveChanges();
                    return true;
                }

                return false;
            }
        }

        public bool Delete(string email)
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                var accountEntity
                     = context.Accounts.Where(x => x.Email.Equals(email)).FirstOrDefault();

                if (accountEntity is not null)
                {
                    context.Accounts.Remove(accountEntity);
                    return context.SaveChanges() > 0;
                }

                return false;
            }
        }

        public List<Account> SearchAccount(string searchValue)
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                if (String.IsNullOrEmpty(searchValue))
                {
                    return context.Accounts.ToList();
                }

                // filter 
                var accounts = context.Accounts.AsQueryable();

                accounts = accounts.Include(a => a.Role).Where(x => x.Email.Contains(searchValue)
                                            || x.Fullname.Contains(searchValue));
                // try parse int
                if (int.TryParse(searchValue, out var memberRole))
                {
                    var result = context.Accounts.ToList();
                    result = result.Where(x => Convert.ToInt32(x.RoleId) == memberRole).ToList();
                    return result;
                }

                return accounts.ToList();
            }
        }

        public List<Account> getAccountByRole(String RoleDecs)
        {
            var dbcontext = new Bird_Farm_Shop_PRNContext();
            return dbcontext.Accounts.Include(a => a.Role).
                Where(account => account.Role.RoleDesc.Equals(RoleDecs)).ToList();
        }

        public List<Account> SearchAccountInRole(string searchValue, string RoleDecs)
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                if (String.IsNullOrEmpty(searchValue))
                {
                    return context.Accounts.Include(a => a.Role).ToList();
                }

                // filter 
                var accounts = context.Accounts.Include(x => x.Role).AsQueryable();

                accounts = accounts.Include(a => a.Role).Where(x => (x.Email.Contains(searchValue)
                                            || x.Fullname.Contains(searchValue))
                                            && x.Role.RoleDesc.Equals(RoleDecs));
                // try parse int
                if (int.TryParse(searchValue, out var memberRole))
                {
                    var result = context.Accounts.Include(a => a.Role).ToList();
                    result = result.Where(x => Convert.ToInt32(x.RoleId) == memberRole).ToList();
                    return result;
                }

                return accounts.ToList();
            }
        }
    }
}

