using System;
using System.Collections.Generic;

namespace BFShopBussinessObjects.Entities
{
    public partial class OrderDetail
    {
        public string OrderDetailId { get; set; } = null!;
        public string OrderId { get; set; } = null!;
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
        public string? ProductId { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual Product? Product { get; set; }
    }
}
