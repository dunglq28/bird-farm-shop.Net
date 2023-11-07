using System;
using System.Collections.Generic;

namespace BFShopBussinessObjects.Entities
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string OrderId { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime? CreateDate { get; set; }
        public int TotalItem { get; set; }
        public double TotalPrice { get; set; }

        public virtual Account EmailNavigation { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
