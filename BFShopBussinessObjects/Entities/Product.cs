using System;
using System.Collections.Generic;

namespace BFShopBussinessObjects.Entities
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string ProductId { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public int CategoryId { get; set; }
        public string? Image { get; set; }
        public string? Age { get; set; }
        public string? Color { get; set; }
        public string? Gender { get; set; }
        public int QuantityAvailable { get; set; }
        public int? QuantitySold { get; set; }
        public double Price { get; set; }
        public double? Discount { get; set; }
        public string? Characteristics { get; set; }
        public string? Detail { get; set; }
        public DateTime DateCreated { get; set; }
        public string Status { get; set; } = null!;

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
