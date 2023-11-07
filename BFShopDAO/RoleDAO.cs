using BFShopBussinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopDAO
{
    public class RoleDAO
    {
        private static RoleDAO instance;
        private static object objectLock = new object();

        public static RoleDAO Instance
        {
            get
            {
                lock (objectLock)
                {
                    if (instance == null)
                    {
                        instance = new RoleDAO();
                    }
                    return instance;
                }
            }
        }

        public Role GetByDesc(string desc)
        {
            using(var context = new Bird_Farm_Shop_PRNContext())
            {
                return context.Roles.Where(x => x.RoleDesc.Equals(desc)).FirstOrDefault();
            }
        }

        public List<Role> GetRoles()
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                return context.Roles.ToList();
            }
        }
    }
}
