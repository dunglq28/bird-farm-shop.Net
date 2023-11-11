using BFShopBussinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopDAO
{
    public class OrderDAO
    {
        private static OrderDAO instance;
        private static object objectLock = new object();

        public static OrderDAO Instance
        {
            get
            {
                lock (objectLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }

        public string createOrderID()
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                var matchingOrders = context.Orders
                    .Where(order => order.OrderId.StartsWith("O"))
                    .Select(order => order.OrderId.Substring(1))
                    .AsEnumerable();

                if (matchingOrders.Any())
                {
                    var maxOrderId = matchingOrders.Max(orderId => int.Parse(orderId));
                    int num = maxOrderId + 1;
                    return "O" + num.ToString("D2");
                }
                else
                {
                    return "O01";
                }
            }

        }

        public bool AddNewOrder(Order order)
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                context.Orders.Add(order);
                return context.SaveChanges() > 0;
            }
        }

        public Order Search(string orderID)
        {
            if (string.IsNullOrEmpty(orderID))
            {
                return null; 
            }

            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                return context.Orders.SingleOrDefault(m => m.OrderId.Equals(orderID));
            }
        }

        public bool DeleteOrder(string orderID)
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                var order = context.Orders.SingleOrDefault(m => m.OrderId.Equals(orderID));
                if (order is null) return false;

                context.Orders.Remove(order);
                return context.SaveChanges() > 0;
            }
        }

    }
}
