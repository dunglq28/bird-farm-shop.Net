using BFShopBussinessObjects.Entities;
using BFShopDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopRepository
{
    public class OrderRepository : IOrderRepository
    {
        public bool AddNewOrder(Order order) => OrderDAO.Instance.AddNewOrder(order);
        public string createOrderID() => OrderDAO.Instance.createOrderID();
        public bool DeleteOrder(string orderID) => OrderDAO.Instance.DeleteOrder(orderID);
        public Order Search(string orderID) => OrderDAO.Instance.Search(orderID);

    }
}
