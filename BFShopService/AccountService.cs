using BFShopBussinessObjects.Entities;
using BFShopRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopService
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepo;

        public AccountService()
            => _accountRepo = new AccountRepository();

        public Account CheckLogin(string username, string password)
            => _accountRepo.CheckLogin(username, password);

        public bool Create(Account account)
            => _accountRepo.Create(account);

        public bool Delete(string email)
            => _accountRepo.Delete(email);

        public Account GetAccount(string? email)
            => _accountRepo.GetAccount(email);

        public Account GetAccountCusByPhone(string? phone)
            => _accountRepo.GetAccountCusByPhone(phone);

        public List<Account> GetAccounts()
            => _accountRepo.GetAccounts();

        public List<Account> getAllAccountByRole(string RoleDecs)
            => _accountRepo.getAllAccountByRole(RoleDecs);

        public List<Account> SearchAccount(string searchValue)
            => _accountRepo.SearchAccount(searchValue);

        public List<Account> SearchAccountInRole(string searchValue, string RoleDecs)
            => _accountRepo.SearchAccountInRole(searchValue, RoleDecs);

        public bool Update(string email, Account account)
            => _accountRepo.Update(email, account);

    }
}
