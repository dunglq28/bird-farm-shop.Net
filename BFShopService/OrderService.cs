using BFShopBussinessObjects.Entities;
using BFShopRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopService
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService()
        {
            _orderRepository = new OrderRepository();
        }

        public bool AddNewOrder(Order order) => _orderRepository.AddNewOrder(order);
        public string createOrderID() => _orderRepository.createOrderID();
        public Order Search(string orderID) => _orderRepository.Search(orderID);

    }
}
