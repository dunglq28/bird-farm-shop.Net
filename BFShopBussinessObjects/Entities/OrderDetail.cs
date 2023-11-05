using System;
using System.Collections.Generic;

namespace BFShopBussinessObjects.Entities
{
    public partial class OrderDetail
    {
        public string OrderId { get; set; } = null!;
        public string ProductId { get; set; } = null!;
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
        public virtual Order Order { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
