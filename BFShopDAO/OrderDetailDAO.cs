using BFShopBussinessObjects.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopDAO
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO instance;
        private static object objectLock = new object();

        public static OrderDetailDAO Instance
        {
            get
            {
                lock (objectLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }

        public bool AddNewOrderDetails(List<OrderDetail> orderDetailList)
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                foreach (var orderDetail in orderDetailList)
                {
                    OrderDetail od = new OrderDetail();
                    od.OrderId = orderDetail.OrderId;
                    od.ProductId = orderDetail.ProductId;
                    od.Quantity = orderDetail.Quantity;
                    od.Price = orderDetail.Price;
                    od.Total = orderDetail.Total;
                    context.OrderDetails.Add(od);
                }
                return context.SaveChanges() > 0;
            }
        }

        public List<OrderDetail> GetOrderDetail(string orderID)
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {   
                if (string.IsNullOrEmpty(orderID))
                {
                    return new List<OrderDetail>();
                }

                var orderDetails = context.OrderDetails
                    .Where(od => od.OrderId.Equals(orderID))
                    .Include(od => od.Product)
                    .ToList();

                return orderDetails;
            }
        }


    }


}
