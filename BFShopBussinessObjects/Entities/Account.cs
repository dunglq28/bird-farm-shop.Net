using System;
using System.Collections.Generic;

namespace BFShopBussinessObjects.Entities
{
    public partial class Account
    {
        public Account()
        {
            Orders = new HashSet<Order>();
        }

        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Fullname { get; set; } = null!;
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? Phone { get; set; }
        public DateTime? Birthday { get; set; }
        public string? Gender { get; set; }
        public int? RoleId { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
