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

        public string OrderId { get; set; }
        public string Email { get; set; }
        public DateTime? CreateDate { get; set; }
        public int TotalItem { get; set; }
        public double TotalPrice { get; set; }

        public virtual Account EmailNavigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
