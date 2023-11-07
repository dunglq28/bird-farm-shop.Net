using BFShopBussinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopService
{
    public interface IAccountService
    {
        bool Create(Account account);
        bool Update(string email, Account account);
        bool Delete(string email);
        Account CheckLogin(string username, string password);
        Account GetAccount(string? email);
        List<Account> GetAccounts();
        List<Account> SearchAccount(string searchValue);
        public List<Account> getAllAccountByRole(String RoleDecs);
        public List<Account> SearchAccountInRole(String searchValue, String RoleDecs);
    }
}
