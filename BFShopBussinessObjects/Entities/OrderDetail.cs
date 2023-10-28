using System;
using System.Collections.Generic;

namespace BFShopBussinessObjects.Entities
{
    public partial class OrderDetail
    {
        public string OrderDetailId { get; set; }
        public string OrderId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int Total { get; set; }
        public string ProductId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
