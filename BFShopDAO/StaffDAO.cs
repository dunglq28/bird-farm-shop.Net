using BFShopBussinessObjects.Entities;
using BFShopBussinessObjects.Utils;
using Microsoft.EntityFrameworkCore;

namespace BFShopDAO
{
    public class StaffDAO
    {
        private static StaffDAO instance = null;

        public static StaffDAO Instance {
            get { 
            if (instance == null)
                {
                    instance = new StaffDAO();
                }
            return instance;
            }
        }

        public List<Account> getAllStaff()
        {
            var dbcontext = new Bird_Farm_Shop_PRNContext();
            return dbcontext.Accounts.Include(a => a.Role).
                Where(account => account.Role.RoleDesc.Equals(Constants.IsStaff)).ToList();
        }

        public bool UpdateStaff(string email, Account account)
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

        public List<Account> SearchStaff(string searchValue, int roleID)
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                if (String.IsNullOrEmpty(searchValue))
                {
                    return context.Accounts.ToList();
                }

                // filter 
                var accounts = context.Accounts.AsQueryable();

                accounts = accounts.Where(x => x.Email.Contains(searchValue)
                                            || x.Fullname.Contains(searchValue)
                                            && x.RoleId == roleID);
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

    }
}