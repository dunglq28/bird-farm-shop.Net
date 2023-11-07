using System;
using System.Collections.Generic;

namespace BFShopBussinessObjects.Entities
{
    public partial class Role
    {
        public Role()
        {
            Accounts = new HashSet<Account>();
        }

        public int RoleId { get; set; }
        public string? RoleDesc { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
