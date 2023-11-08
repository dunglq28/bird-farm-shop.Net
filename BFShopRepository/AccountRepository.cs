using BFShopBussinessObjects.Entities;
using BFShopDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopRepository
{
    public class AccountRepository : IAccountRepository
    {
        public Account CheckLogin(string username, string password)
            => AccountDAO.Instance.CheckLogin(username, password);

        public bool Create(Account account)
            => AccountDAO.Instance.Create(account);

        public bool Delete(string email)
            => AccountDAO.Instance.Delete(email);

        public Account GetAccount(string? email)
            => AccountDAO.Instance.GetAccount(email);

        public Account GetAccountCusByPhone(string? phone)
            => AccountDAO.Instance.GetAccountCusByPhone(phone);

        public List<Account> GetAccounts()
            => AccountDAO.Instance.GetAccounts();

        public List<Account> getAllAccountByRole(String RoleDecs)
            => AccountDAO.Instance.getAccountByRole(RoleDecs);

        public List<Account> SearchAccount(string searchValue)
            => AccountDAO.Instance.SearchAccount(searchValue);

        public List<Account> SearchAccountInRole(string searchValue, string RoleDecs)
            => AccountDAO.Instance.SearchAccountInRole(searchValue, RoleDecs);

        public bool Update(string email, Account account)
            => AccountDAO.Instance.Update(email, account);
    }
}
